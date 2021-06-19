using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Simple_ALE_Browser
{
    // SimplerAES from https://stackoverflow.com/a/5518092

    class SimplerAES
    {
        // Generated from www.random.org

        private static readonly byte[] key = { 8, 10, 19, 22, 35, 42, 44, 48, 54, 63, 85, 87, 90, 95, 105, 138, 140, 142, 144, 151, 172, 175, 176, 185, 193, 211, 219, 223, 231, 233, 241, 242 };
        private static readonly byte[] vector = { 33, 42, 45, 50, 68, 90, 153, 165, 174, 175, 187, 200, 225, 236, 239, 242 };

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
}
