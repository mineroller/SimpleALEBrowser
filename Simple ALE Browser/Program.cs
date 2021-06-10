using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

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

            // SimplerAES from https://stackoverflow.com/a/5518092

            public class SimplerAES
            {
                // Generated from www.random.org

                private static byte[] key = { 86, 109, 109, 186, 43, 36, 71, 167, 241, 208, 156, 69, 130, 214, 48, 196, 77, 125, 121, 56, 231, 196, 120, 223, 254, 222, 11, 155, 38, 174, 154, 68 };
                private static byte[] vector = { 252, 64, 31, 74, 254, 45, 244, 96, 229, 39, 217, 26, 7, 14, 86, 22 };
                
                private ICryptoTransform encryptor, decryptor;
                private UTF8Encoding encoder;

                public SimplerAES()
                {
                    RijndaelManaged rm = new RijndaelManaged();
                    encryptor = rm.CreateEncryptor(key, vector);
                    decryptor = rm.CreateDecryptor(key, vector);
                    encoder = new UTF8Encoding();
                }

                public string Encrypt(string unencrypted)
                {
                    return Convert.ToBase64String(Encrypt(encoder.GetBytes(unencrypted)));
                }

                public string Decrypt(string encrypted)
                {
                    return encoder.GetString(Decrypt(Convert.FromBase64String(encrypted)));
                }

                public byte[] Encrypt(byte[] buffer)
                {
                    return Transform(buffer, encryptor);
                }

                public byte[] Decrypt(byte[] buffer)
                {
                    return Transform(buffer, decryptor);
                }

                protected byte[] Transform(byte[] buffer, ICryptoTransform transform)
                {
                    MemoryStream stream = new MemoryStream();
                    using (CryptoStream cs = new CryptoStream(stream, transform, CryptoStreamMode.Write))
                    {
                        cs.Write(buffer, 0, buffer.Length);
                    }
                    return stream.ToArray();
                }
            }

            public static string GetConnStr()
            {

                SimplerAES aes = new SimplerAES();
                
                string _connstr =
                    "Server=" + Properties.Settings.Default.ServerName +
                    @"\" + Properties.Settings.Default.InstanceName + ";" +
                    "Database=" + Properties.Settings.Default.DatabaseName + ";" +
                    "User Id=" + Properties.Settings.Default.Login + ";" +
                    "Password=" + aes.Decrypt(Properties.Settings.Default.Password) + ";";
                return _connstr;
            }
          

        }

    }

}
