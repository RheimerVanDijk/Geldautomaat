using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace GeldautomaatClassLibrary
{
    public class PasswordConvert
    {
        public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

       public string randomPincode()
        {
            Random RandNum = new Random();
            int randomPincode = RandNum.Next(1000, 9999);
            string pinCode = ComputeSha256Hash(randomPincode.ToString());

            return pinCode;
        }
    }
}
