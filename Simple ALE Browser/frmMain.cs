using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_ALE_Browser
{
    public partial class frmMain : Form
    {        

        public frmMain()
        {                        
            InitializeComponent();

            // Diable all controls until ready to connecct

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            tabControl1.Enabled = false;
            cmbUserList.Items.Clear();
            btnQueryUser.Enabled = false;
            dpkFromDate.Enabled = false;
            dpkFromTime.Enabled = false;
            dpkToDate.Enabled = false;
            dpkToTime.Enabled = false;
            lblSqlServerDetails.Text = "[Not Connected]";            

            // If setting is not ready, disable connect button

            if (Properties.Settings.Default.ServerName == "")
            {
                lblTargetServer.Text = "PLEASE CONFIG FIRST";
                lblTargetServer.ForeColor = Color.Red;
                btnConnectSQL.Enabled = false;
            }
            else
            {
                lblTargetServer.Text = Properties.Settings.Default.ServerName + @"\" + Properties.Settings.Default.InstanceName;
                btnConnectSQL.Enabled = true;
            }
            
        }
        
        private void configureSQLConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingsForm = new frmSettings();
            settingsForm.ShowDialog(this);

            lblTargetServer.Text = Properties.Settings.Default.ServerName + @"\" + Properties.Settings.Default.InstanceName;
            lblTargetServer.ForeColor = Color.Black;
            btnConnectSQL.Enabled = true;

        }

        private void btnConnectSQL_Click(object sender, EventArgs e)
        {
            
            string alev_cs = Program.VUStringHelper.GetConnStr();
            string sqlver = "";
            int alev_rows = 0;            
            
            try
            {
                using (SqlConnection alevconn = new SqlConnection(alev_cs))
                {
                    alevconn.Open();
                  
                    string query_initver = "SELECT @@VERSION";                    
                    using (SqlCommand alevcmd = new SqlCommand(query_initver, alevconn))
                    {
                        using (SqlDataReader alevreader = alevcmd.ExecuteReader())
                        {
                            while (alevreader.Read())
                            {
                                sqlver = alevreader.GetString(0);
                            }
                            lblSqlServerDetails.Text = sqlver;
                            groupBox1.Enabled = true;
                        }
                    }

                    string query_initrows = "SELECT COUNT(*) from AuditEntry";
                    using (SqlCommand alevcmd = new SqlCommand(query_initrows, alevconn))
                    {
                        using (SqlDataReader alevreader = alevcmd.ExecuteReader())
                        {
                            while (alevreader.Read())
                            {
                                alev_rows = alevreader.GetInt32(0);
                            }
                            lblDbRows.Text = alev_rows.ToString("N0") + " events in ALEV";
                            groupBox2.Enabled = true; 
                        }
                    }                    

                }

                lblStatusDisp.Text = "Initial database connection SUCESS";
                lblStatusDisp.ForeColor = Color.SpringGreen;
                tabControl1.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error:" + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatusDisp.Text = "Initial database connection FAIL";
                lblStatusDisp.ForeColor = Color.Red;
            }
        }

        private void btnGetUsers_Click(object sender, EventArgs e)
        {
            cmbUserList.Items.Clear();

            string alev_cs = Program.VUStringHelper.GetConnStr();
            string alev_users = "";
            try
            {
                using (SqlConnection alevconn = new SqlConnection(alev_cs))
                {
                    alevconn.Open();

                    string query_userlist = "SELECT DISTINCT UserName from AuditEntry FOR JSON AUTO";
                    using (SqlCommand alevcmd = new SqlCommand(query_userlist, alevconn))
                    {
                        using (SqlDataReader alevreader = alevcmd.ExecuteReader())
                        {
                            while (alevreader.Read())
                            {
                                alev_users = alevreader.GetString(0);
                            }

                            List<UserList> alevuserlist = JsonConvert.DeserializeObject<List<UserList>>(alev_users);

                            foreach (UserList _user in alevuserlist)
                            {
                                cmbUserList.Items.Add(_user.UserName);
                            }
                            cmbUserList.SelectedIndex = 0;
                            lblStatusDisp.Text = "Total " + alevuserlist.Count().ToString() + " users found.";
                            btnQueryUser.Enabled = true;
                            dpkFromDate.Enabled = true;
                            dpkFromTime.Enabled = true;
                            dpkToDate.Enabled = true;
                            dpkToTime.Enabled = true;

                            dpkFromDate.Value = DateTime.Now;
                            dpkFromTime.Value = DateTime.Now.AddMinutes(-30);

                            dpkToDate.Value = DateTime.Now;
                            dpkToTime.Value = DateTime.Now;                            
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error:" + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatusDisp.Text = "Error in SQL Query. Check connection to SQL.";
                lblStatusDisp.ForeColor = Color.Red;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutSimpleAuditLogViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new frmAbout();
            aboutForm.ShowDialog(this);
        }

        private void btnQueryUser_Click(object sender, EventArgs e)
        {
                        
            DateTime _from = dpkFromDate.Value.Date + dpkFromTime.Value.TimeOfDay;
            DateTime _to = dpkToDate.Value.Date + dpkToTime.Value.TimeOfDay;
          
            if (_from > _to)
            {
                MessageBox.Show("Incorrect FROM/TO Time period. Please re-select time.", "Wrong Time Period", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            else
            {
                try
                {
                    string alev_cs = Program.VUStringHelper.GetConnStr();
                    using (SqlConnection alevconn = new SqlConnection(alev_cs))
                    {
                        alevconn.Open();
                        string query_useraudit = "SELECT TOP(1000)" +
                            " ActionDateLocal,UserName,ComputerName,Information" +
                            " FROM AuditEntry " +
                            " WHERE UserName ='" + cmbUserList.SelectedItem.ToString() + "'" +
                            " AND ActionDateLocal >= '" + _from.ToString("yyyy-MM-ddTHH:mm:ss") + "'" +
                            " AND ActionDateLocal <= '" + _to.ToString("yyyy-MM-ddTHH:mm:ss") + "'" +
                            " ORDER BY ActionDateLocal DESC FOR JSON AUTO";
                        
                        StringBuilder result_json = new StringBuilder();
                        using (SqlCommand alevcmd = new SqlCommand(query_useraudit, alevconn))
                        {                        
                            using (SqlDataReader alevreader = alevcmd.ExecuteReader())
                            {
                                
                                // if ExecuteReader returns no rows, list becomes NULL and cannot ToString().
                                // If no rows, create an empty JSON string by appending [].
                                
                                if (!alevreader.HasRows)
                                {
                                    result_json.Append("[]");
                                }
                                else
                                {
                                    while (alevreader.Read())
                                    {
                                        result_json.Append(alevreader.GetString(0));
                                    }
                                }                          
                            
                                List<UserAuditResult> userAuditResults = JsonConvert.DeserializeObject<List<UserAuditResult>>(result_json.ToString());
                                lblStatusDisp.Text = "Total " + userAuditResults.Count() + " events found.";
                                olvUserAuditResult.SetObjects(userAuditResults);                            
                            }                        
                        }                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error:" + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatusDisp.Text = "Error in SQL Query. Check connection to SQL.";
                    lblStatusDisp.ForeColor = Color.Red;
                }
            }       
        }
    }
}
