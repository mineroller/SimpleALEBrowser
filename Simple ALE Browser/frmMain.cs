using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Simple_ALE_Browser
{
    public partial class frmMain : Form
    {
        string alev_cs = Program.VUStringHelper.GetConnStr();

        public frmMain()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            tabControl1.Enabled = false;
            cmbUserList.Items.Clear();
            lblSqlServerDetails.Text = "[Not Connected]";
            lblTargetServer.Text = Properties.Settings.Default.ServerName + @"\" + Properties.Settings.Default.InstanceName;
        }
        
        private void configureSQLConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingsForm = new frmSettings();
            settingsForm.ShowDialog(this);

            lblTargetServer.Text = Properties.Settings.Default.ServerName + @"\" + Properties.Settings.Default.InstanceName;

        }

        private void btnConnectSQL_Click(object sender, EventArgs e)
        {
            
            string sqlver = "";
            int alev_rows = 0;            
            
            try
            {
                using (SqlConnection alevconn = new SqlConnection(alev_cs))
                {
                    alevconn.Open();
                  
                    string init_ver = "SELECT @@VERSION";                    
                    using (SqlCommand alevcmd = new SqlCommand(init_ver, alevconn))
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

                    string init_rows = "SELECT COUNT(*) from AuditEntry";
                    using (SqlCommand alevcmd = new SqlCommand(init_rows, alevconn))
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

            string alev_users = "";
            
            using (SqlConnection alevconn = new SqlConnection(alev_cs))
            {
                alevconn.Open();                

                string user_list = "SELECT DISTINCT UserName from AuditEntry FOR JSON AUTO";
                using (SqlCommand alevcmd = new SqlCommand(user_list, alevconn))
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
                        // lblTempHolder.Text = alev_users;
                    }
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
