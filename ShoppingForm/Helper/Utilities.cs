using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingForm.Helper
{
    public static class Utilities
    {
        public static bool IsEmpty(string[] arr)
        {
            foreach (var a in arr)
            {
                if (string.IsNullOrWhiteSpace(a))
                {
                    return false;
                }
            }
            return true;
        }
        public static string HashMe(string pass)
        {
            byte[] arr1 = Encoding.UTF8.GetBytes(pass);
            var hashedPass = SHA256Managed.Create().ComputeHash(arr1);
            string hashedString = Encoding.UTF8.GetString(hashedPass);
            return hashedString;
        }
    }
}
