using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HelperClasses
{
    /// <summary>
    /// 
    /// </summary>
    public static class Password
    {
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strToEncrypt"></param>
        /// <returns></returns>
        public static string encrypt(string strToEncrypt)
        {
            string hash = "";
            string ecnryptedString = null;
            byte[] data = UTF8Encoding.UTF8.GetBytes(strToEncrypt);
            using (MD5CryptoServiceProvider mdServ = new MD5CryptoServiceProvider())
            {
                // Compute hash method returns the hash as an array of 16 bytes
                byte[] keys = mdServ.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));

                //format the return valus as hexadecimal value
                using (TripleDESCryptoServiceProvider tripServ = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripServ.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    ecnryptedString = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return ecnryptedString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strToDecrypt"></param>
        /// <returns></returns>
        public static string decrypt(string strToDecrypt)
        {
            string hash = "";
            string decryptedString = null;
            byte[] data = Convert.FromBase64String(strToDecrypt);
            using (MD5CryptoServiceProvider mdServ = new MD5CryptoServiceProvider())
            {
                // Compute hash method returns the hash as an array of 16 bytes
                byte[] keys = mdServ.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));

                //format the return valus as hexadecimal value
                using (TripleDESCryptoServiceProvider tripServ = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripServ.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    decryptedString = UTF8Encoding.UTF8.GetString(results);
                }
            }
            return decryptedString;
        }
    }
}
