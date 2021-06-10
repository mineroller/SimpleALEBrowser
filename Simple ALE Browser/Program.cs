using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace Simple_ALE_Browser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }        

        public static class VUStringHelper
        {

            /// Encodes string that can only be accessible from this machine

            public static string Encode(string text)
            {
                return Convert.ToBase64String(
                    ProtectedData.Protect(
                        Encoding.Unicode.GetBytes(text), null, DataProtectionScope.LocalMachine));
            }

            /// Decodes the encrypted string, only accessible from this machine

            public static string Decode(string text)
            {
                return Encoding.Unicode.GetString(
                        ProtectedData.Unprotect(
                            Convert.FromBase64String(text), null, DataProtectionScope.LocalMachine));
            }

            public static string EncBase64(string text)
            {
                /// Grabs username and password from setting, decode it, and prepare for Base64 encoding
                byte[] _text2byte = Encoding.UTF8.GetBytes(text);
                string base64_text = Convert.ToBase64String(_text2byte);

                return base64_text;
            }

            /// IP Address Validator. From https://stackoverflow.com/a/29942932

            public static Boolean ValidateIP(string address)
            {
                /// Split string by ".", check that array length is 4
                string[] ipv4octets = address.Split('.');
                if (ipv4octets.Length != 4)
                    return false;

                /// Check each substring checking that parses to byte
                byte obyte = 0;
                foreach (string singleOctet in ipv4octets)
                    if (!byte.TryParse(singleOctet, out obyte))
                        return false;

                return true;
            }

            public static string GetConnStr()
            {
                // string _connstr = @"Server=IVALEV\SQLEXPRESS; Database=IV_ALEV; User Id=ivaudituser; Password=1q2w3e4r!;";
                string _connstr =
                    "Server=" + Properties.Settings.Default.ServerName +
                    @"\" + Properties.Settings.Default.InstanceName + ";" +
                    "Database=" + Properties.Settings.Default.DatabaseName + ";" +
                    "User Id=" + Properties.Settings.Default.Login + ";" +
                    "Password=" + Decode(Properties.Settings.Default.Password) + ";";
                return _connstr;
            }
          

        }

    }

}
