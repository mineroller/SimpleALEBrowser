using System;
using System.IO;

namespace Simple_ALE_Browser
{
    class Helpers
    {
        public static string GetConnStr(SABSettings _settings)
        {

            SimplerAES aes = new SimplerAES();

            string _connstr =
                "Server=" + _settings.ServerName +
                @"\" + _settings.InstanceName +
                ";Database=" + _settings.DatabaseName +
                ";User Id=" + _settings.LoginName +
                ";Password=" + aes.Decrypt(_settings.Password);
            return _connstr;
        }

        public static string CheckConfig()
        {
            string settings_dir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Hananet\SimpleALEBrowser";
            string settings_json = settings_dir + @"\sab-settings.json";

            if (File.Exists(settings_json))
            {
                return settings_json;
            }
            else
            {
                return "NA";
            }
        }
    }
}
