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

            // Diable all form controls until ready to connecct

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            tabControl1.Enabled = false;            

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

        private async void btnConnectSQL_Click(object sender, EventArgs e)
        {

            // Create SQL Connection String using setting values

            string alev_cs = Program.VUStringHelper.GetConnStr();            
            int alev_rows = 0;            
            
            try
            {
                btnConnectSQL.Text = "Connecting...";
                btnConnectSQL.Enabled = false;
                menuStrip1.Enabled = false;

                using (SqlConnection alevconn = new SqlConnection(alev_cs))
                {
                    await alevconn.OpenAsync();

                    StringBuilder result_version = new StringBuilder();
                    string query_initver = "SELECT @@VERSION";                    
                    using (SqlCommand alevcmd = new SqlCommand(query_initver, alevconn))
                    {
                        using (SqlDataReader alevreader = alevcmd.ExecuteReader())
                        {
                            while (await alevreader.ReadAsync())
                            {
                                result_version.Append(alevreader.GetString(0));
                            }

                            string sqlver_long = result_version.ToString();

                            string[] sqlver_array = sqlver_long.Split(
                                new[] { "\n\t", "\n" }, StringSplitOptions.None);

                            
                            toolStripStatusLabel1.Text = sqlver_array[0];
                            toolStripStatusLabel2.Text = sqlver_array[3];                                                       
                        }
                    }

                    string query_initrows = "SELECT COUNT(*) from AuditEntry";
                    using (SqlCommand alevcmd = new SqlCommand(query_initrows, alevconn))
                    {
                        using (SqlDataReader alevreader = alevcmd.ExecuteReader())
                        {
                            while (await alevreader.ReadAsync())
                            {
                                alev_rows = alevreader.GetInt32(0);
                            }
                            lblDbRows.Text = alev_rows.ToString("N0") + " events in ALEV";
                            groupBox2.Enabled = true; 
                        }
                    }

                    DateTime result_oldestrow = new DateTime();
                    string query_oldestrow = "SELECT TOP(1) ActionDateLocal from AuditEntry ORDER BY ActionDateLocal ASC";
                    using (SqlCommand alevcmd = new SqlCommand(query_oldestrow, alevconn))
                    {
                        using (SqlDataReader alevreader = alevcmd.ExecuteReader())
                        {
                            while (await alevreader.ReadAsync())
                            {
                                result_oldestrow = alevreader.GetDateTime(0);
                            }
                            lblOldestRow.Text = result_oldestrow.ToString();
                            groupBox2.Enabled = true;
                        }
                    }

                }               
                lblStatusDisp.Text = "Initial database connection SUCCESS";
                lblStatusDisp.ForeColor = Color.SpringGreen;
                tabControl1.Enabled = true;
                groupBox1.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error:" + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatusDisp.Text = "Initial database connection FAIL";
                lblStatusDisp.ForeColor = Color.Red;
            }
            finally
            {
                btnConnectSQL.Text = "Connect to ALEV";
                btnConnectSQL.Enabled = true;
                menuStrip1.Enabled = true;

                cmbUserList.Enabled = false;
                cmbComputerList.Enabled = false;
                cmbActionId.Enabled = false;
                btnQueryUser.Enabled = false;
            }
        }

        private async void btnInit_Click(object sender, EventArgs e)
        {
            cmbUserList.Items.Clear();
            cmbComputerList.Items.Clear();
            cmbActionId.Items.Clear();

            string alev_cs = Program.VUStringHelper.GetConnStr();
            
            try
            {
                using (SqlConnection alevconn = new SqlConnection(alev_cs))
                {
                    await alevconn.OpenAsync();

                    string query_userlist = "SELECT DISTINCT UserName from AuditEntry FOR JSON AUTO";
                    using (SqlCommand alevcmd = new SqlCommand(query_userlist, alevconn))
                    {
                        string alev_users = "";
                        using (SqlDataReader alevreader = await alevcmd.ExecuteReaderAsync())
                        {
                            while (alevreader.Read())
                            {
                                alev_users = alevreader.GetString(0);
                            }

                            List<AlevUser> alevuserlist = JsonConvert.DeserializeObject<List<AlevUser>>(alev_users);

                            foreach (AlevUser _user in alevuserlist)
                            {
                                cmbUserList.Items.Add(_user.UserName);
                            }
                            cmbUserList.Items.Add("(Any)");
                            cmbUserList.SelectedIndex = 0;
                            cmbUserList.Enabled = true;
                            lblStatusDisp.Text = "Total " + alevuserlist.Count().ToString() + " users found.";
                                                        
                        }
                    }

                    string query_cclist = "SELECT DISTINCT ComputerName from AuditEntry FOR JSON AUTO";
                    using (SqlCommand alevcmd = new SqlCommand(query_cclist, alevconn))
                    {
                        using (SqlDataReader alevreader = await alevcmd.ExecuteReaderAsync())
                        {
                            string alev_cc = "";
                            while (alevreader.Read())
                            {
                                alev_cc = alevreader.GetString(0);
                            }

                            List<AlevCC> alevcclist = JsonConvert.DeserializeObject<List<AlevCC>>(alev_cc);

                            foreach (AlevCC _cc in alevcclist)
                            {
                                cmbComputerList.Items.Add(_cc.ComputerName);
                            }
                            cmbComputerList.Items.Add("(Any)");
                            cmbComputerList.SelectedIndex = 0;
                            cmbComputerList.Enabled = true;
                            lblStatusDisp.Text += "\nTotal " + alevcclist.Count().ToString() + " computers found.";

                        }
                    }                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error:" + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatusDisp.Text = "Error in SQL Query. Check connection to server.";
                lblStatusDisp.ForeColor = Color.Red;
            }
            finally
            {
                List<AlevAction> _defActions = SetDefaultActionIds();

                foreach (AlevAction _action in _defActions)
                {
                    cmbActionId.Items.Add(_action);
                }

                cmbActionId.DataSource = _defActions;
                cmbActionId.DisplayMember = "DisplayText";
                cmbActionId.ValueMember = "InString";
                cmbActionId.SelectedIndex = 0;                
                cmbActionId.Enabled = true;

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

        private List<AlevAction> SetDefaultActionIds()
        {            
            List<AlevAction> _actionList = new List<AlevAction>();

            _actionList.Add(new AlevAction("(Any)", 0, 0, 0));
            _actionList.Add(new AlevAction("Login-Logout", 31, 33, 0));
            _actionList.Add(new AlevAction("Alarm Received", 67, 68, 69));            
            _actionList.Add(new AlevAction("Bookmark Added", 81, 0, 0));
            _actionList.Add(new AlevAction("Recorded Video Fail/Denied", 51, 52, 0));
            _actionList.Add(new AlevAction("Playback Video", 35, 36, 37));
            _actionList.Add(new AlevAction("Export Video", 9, 10, 13));
            _actionList.Add(new AlevAction("Live Video", 60, 61, 62));
            _actionList.Add(new AlevAction("Export Incident", 88, 0, 0));
            _actionList.Add(new AlevAction("Change Permissions", 78, 79, 80));

            return _actionList;
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

        private async void btnQueryUser_Click(object sender, EventArgs e)
        {
            olvUserAuditResult.Enabled = false;
                        
            DateTime _from = dpkFromDate.Value.Date + dpkFromTime.Value.TimeOfDay;
            DateTime _to = dpkToDate.Value.Date + dpkToTime.Value.TimeOfDay;
            btnQueryUser.Enabled = false;
          
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
                        await alevconn.OpenAsync();
                        string query_useraudit = BuildUserQuery(_from, _to);
                        
                        StringBuilder result_json = new StringBuilder();
                        using (SqlCommand alevcmd = new SqlCommand(query_useraudit, alevconn))
                        {
                            lblStatusDisp.Text = "Query in progress...";

                            if (txtObjectName.Text != "")
                            {
                                SqlParameter p = new SqlParameter("@ObjectName", System.Data.SqlDbType.NVarChar, 255)
                                {
                                    Value = "%" + txtObjectName.Text + "%"
                                };
                                alevcmd.Parameters.AddWithValue(p.ParameterName, p.Value);
                            }                            
                            using (SqlDataReader alevreader = await alevcmd.ExecuteReaderAsync())
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

                                switch (userAuditResults[0].Total)
                                {
                                    case int n when n == 0:
                                        lblStatusDisp.Text = "No matching records found";
                                        lblStatusDisp.ForeColor = Color.Gold;
                                        break;
                                    case int n when n <= numMaxRows.Value:
                                        lblStatusDisp.Text = "Total " + userAuditResults[0].Total.ToString() + " events found.";
                                        lblStatusDisp.ForeColor = Color.SpringGreen;
                                        break;
                                    case int n when n > numMaxRows.Value:
                                        lblStatusDisp.Text = "Total " + userAuditResults[0].Total.ToString() + " events found.\nShowing top " + userAuditResults.Count() + " results.";
                                        lblStatusDisp.ForeColor = Color.SpringGreen;
                                        break;
                                }

                                olvUserAuditResult.SetObjects(userAuditResults);
                                olvUserAuditResult.Enabled = true;
                                btnQueryUser.Enabled = true;
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

        private string BuildUserQuery(DateTime _from, DateTime _to)
        {
            string _query = "SELECT TOP(" + numMaxRows.Value.ToString() + ") " +
                "ActionDateLocal,UserName,ComputerName,Information,SourceIp, " +
                "COUNT(*) OVER() Total " +
                "FROM AuditEntry WHERE ";

            if (cmbUserList.SelectedIndex != 0)
            {
                _query += "UserName = '" + cmbUserList.SelectedItem.ToString() + "' AND ";
            }

            if (cmbComputerList.SelectedIndex != 0)
            {
                _query += "ComputerName ='" + cmbComputerList.SelectedItem.ToString() + "' AND ";
            }
            
            if (cmbActionId.SelectedIndex != 0)
            {
                AlevAction _actionvalue = (AlevAction)cmbActionId.SelectedItem;
                _query += "ActionId IN " + _actionvalue.InString + " AND ";
            }

            if (txtObjectName.Text != "")
            {
                _query += "ObjectName LIKE @ObjectName AND ";
            }
            
            _query += "ActionDateLocal >= '" + _from.ToString("yyyy-MM-ddTHH:mm:ss") + "'" +
                " AND ActionDateLocal <= '" + _to.ToString("yyyy-MM-ddTHH:mm:ss") + "'" +
                " ORDER BY ActionDateLocal DESC FOR JSON AUTO";

            return _query;
        }
    }
}
