using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DecryptAndEncrypt
{
    class MD5Cipher
    {

        public static string decrypt(string text, string hash)
        {
            byte[] data = Convert.FromBase64String(text);
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateDecryptor();
            try
            {
                return UTF8Encoding.UTF8.GetString(transform.TransformFinalBlock(data, 0, data.Length));
            } catch (CryptographicException exc) {
                return "Podany HASH nie jest poprawny, brak mozliwosci odszyfrowania";
            }
            
        }

        public static string encrypt(string text, string hash)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(text);
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateEncryptor();

            return Convert.ToBase64String(transform.TransformFinalBlock(data, 0, data.Length));
        }

    }
}
