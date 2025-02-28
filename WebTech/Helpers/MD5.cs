using System;
using System.Text;
using System.Security.Cryptography;

namespace TechDep
{
    class MD5
    {
        public static string HashPassword(string password)
        {
            var md5 = System.Security.Cryptography.MD5.Create();
            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);
            StringBuilder sb = new StringBuilder();

            foreach (var a in hash)
            {
                sb.Append(a.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
