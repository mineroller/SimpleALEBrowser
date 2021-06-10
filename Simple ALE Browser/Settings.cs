using System;
using System.Windows.Forms;

namespace Simple_ALE_Browser
{
    public partial class frmSettings : Form
    {
        public bool SettingSaved { get; set; }
        
        public frmSettings()
        {
            InitializeComponent();
            chkUnmask.Checked = false;

            try
            {
                loadPreviousSettings();
            }
            catch
            {
                MessageBox.Show("No default values Found.\n\nNew default values will be created.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                setDefaultSettings();
                loadPreviousSettings();
            }
            finally
            {
                SettingSaved = false;
            }
                
        }

        private void loadPreviousSettings()
        {
            txtServerName.Text = Properties.Settings.Default.ServerName;
            txtInstanceName.Text = Properties.Settings.Default.InstanceName;
            txtLogin.Text = Properties.Settings.Default.Login;
            txtDatabaseName.Text = Properties.Settings.Default.DatabaseName;
            txtPassword.Text = Program.VUStringHelper.Decode(Properties.Settings.Default.Password);
        }

        private void setDefaultSettings()
        {            
            Properties.Settings.Default.ServerName = "IVALEV";
            Properties.Settings.Default.InstanceName = "SQLEXPRESS";
            Properties.Settings.Default.DatabaseName = "IV_ALEV";
            Properties.Settings.Default.Password = Program.VUStringHelper.Encode("1q2w3e4r!");
            Properties.Settings.Default.Login = "ivaudituser";            
            Properties.Settings.Default.Save();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerName = txtServerName.Text;
            Properties.Settings.Default.InstanceName = txtInstanceName.Text;
            Properties.Settings.Default.Login = txtLogin.Text;
            Properties.Settings.Default.DatabaseName = txtDatabaseName.Text;
            Properties.Settings.Default.Password = Program.VUStringHelper.Encode(txtPassword.Text);

            SettingSaved = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLoadDefault_Click(object sender, EventArgs e)
        {
            setDefaultSettings();
            loadPreviousSettings();
        }

        private void btnCancelSettings_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkUnmask_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnmask.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;                
            }
            else
            {                
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
