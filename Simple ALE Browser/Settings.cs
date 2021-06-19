using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Simple_ALE_Browser
{
    public partial class frmSettings : Form
    {

        public static string settings_dir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Hananet\SimpleALEBrowser";              

        public frmSettings()
        {
            InitializeComponent();

            SABSettings currentSetting = new SABSettings();
            string settings_json = settings_dir + @"\sab-settings.json";
            lblSettingsJsonLocation.Text = settings_json;


            if (!Directory.Exists(settings_dir))
            {
                Directory.CreateDirectory(settings_dir);
            }


            if (File.Exists(settings_json))
            {
                try
                {
                    currentSetting = JsonConvert.DeserializeObject<SABSettings>(File.ReadAllText(settings_json));
                    LoadSettings(currentSetting);
                }
                catch (JsonReaderException ex)
                {
                    MessageBox.Show("JSON Read Exception: " + ex.Message + "\n\nCreating a new default configuration file.", "Error reading config file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.Delete(settings_json);

                    currentSetting = CreateDefaultSettings();
                    using (StreamWriter sw = File.CreateText(settings_json))
                    {
                        JsonSerializer sr = new JsonSerializer();
                        sr.Serialize(sw, currentSetting);
                    }
                    LoadSettings(currentSetting);
                }
                finally
                {
                    toolStripStatusLabel1.Text = "JSON File saved at: " + File.GetLastWriteTime(settings_json).ToString("G");
                }
            }
            else
            {
                MessageBox.Show("Cannot find file " + settings_json + ".\n\nCreating a default JSON file.", "No settings found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                currentSetting = CreateDefaultSettings();

                using (StreamWriter sw = File.CreateText(settings_json))
                {
                    JsonSerializer sr = new JsonSerializer();
                    sr.Serialize(sw, currentSetting);
                }

                LoadSettings(currentSetting);
                toolStripStatusLabel1.Text = "JSON File saved at: " + File.GetLastWriteTime(settings_json).ToString("G");
            }
            
        }

        private void LoadSettings(SABSettings _settings)
        {
            SimplerAES aes = new SimplerAES();

            txtServerName.Text = _settings.ServerName;
            txtInstanceName.Text = _settings.InstanceName;
            txtDatabaseName.Text = _settings.DatabaseName;
            txtLogin.Text = _settings.LoginName;
            txtPassword.Text = aes.Decrypt(_settings.Password);
            txtOnvifLogin.Text = _settings.OnvifLogin;
            txtOnvifPassword.Text = aes.Decrypt(_settings.OnvifPassword);

        }

        private SABSettings SaveSettings(SABSettings _settings)
        {
            SimplerAES aes = new SimplerAES();

            _settings.ServerName = txtServerName.Text;
            _settings.InstanceName = txtInstanceName.Text;
            _settings.DatabaseName = txtDatabaseName.Text;
            _settings.LoginName = txtLogin.Text;
            _settings.Password = aes.Encrypt(txtPassword.Text);
            _settings.OnvifLogin = txtOnvifLogin.Text;
            _settings.OnvifPassword = aes.Encrypt(txtOnvifPassword.Text);

            return _settings;

        }

        private SABSettings CreateDefaultSettings()
        {
            SimplerAES aes = new SimplerAES();

            SABSettings _default = new SABSettings
            {
                IsConfigured = true,
                ServerName = "SQL2019",
                InstanceName = "SQLEXPRESS",
                DatabaseName = "IV_ALEV",
                LoginName = "ivaudituser",
                Password = aes.Encrypt("Pel2899100@"),
                OnvifLogin = "admin",
                OnvifPassword = aes.Encrypt("admin")
            };

            return _default;
        }

        private void btnSaveSettings_Click(object sender, System.EventArgs e)
        {
            SABSettings newSettings = new SABSettings();

            SaveSettings(newSettings);

            string settings_json = settings_dir + @"\sab-settings.json";

            using (StreamWriter sw = File.CreateText(settings_json))
            {
                JsonSerializer sr = new JsonSerializer();
                sr.Serialize(sw, newSettings);
            }

            LoadSettings(newSettings);
            toolStripStatusLabel1.Text = "JSON File saved at: " + File.GetLastWriteTime(settings_json).ToString("G");
        }

        private void btnLoadDefault_Click(object sender, EventArgs e)
        {
            SABSettings _defaultSettings = CreateDefaultSettings();
            LoadSettings(_defaultSettings);
        }

        private void btnCancelSettings_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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

        private void chkOnvifUnmask_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnvifUnmask.Checked == true)
            {
                txtOnvifPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtOnvifPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
