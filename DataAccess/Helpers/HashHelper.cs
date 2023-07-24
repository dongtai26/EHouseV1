using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Helpers
{
    public class HashHelper
    {
        public static String HmacSHA512(string key, string inputData)
        {
            var hash = new StringBuilder();
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] inputBytes = Encoding.UTF8.GetBytes(inputData);
            using (var hmac = new HMACSHA512(keyBytes))
            {
                byte[] hashValue = hmac.ComputeHash(inputBytes);
                foreach (var theByte in hashValue)
                {
                    hash.Append(theByte.ToString("x2"));
                }
            }
            return hash.ToString();
        }

        public static String HmacSHA256(string inputData, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] massageBytes = Encoding.UTF8.GetBytes(inputData);
            using (var hmacsha256 = new HMACSHA256(keyBytes))
            {
                byte[] hashmassage = hmacsha256.ComputeHash(massageBytes);
                string hex = BitConverter.ToString(hashmassage);
                hex = hex.Replace("-", "").ToLower();
                return hex;
            }
        }
    }
}
