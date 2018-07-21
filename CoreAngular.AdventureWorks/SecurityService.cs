using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CoreAngular.AdventureWorks
{
    public class SecurityService
    {
        public static string GenerateHashedPassword(string salt, string password)
        {
            var sBytes = Convert.FromBase64String(salt);
            var pBytes = Encoding.ASCII.GetBytes(password);
            var sVal = sBytes.Concat(pBytes).ToArray();
            sVal = SHA256.Create().ComputeHash(sVal);
            return Convert.ToBase64String(sVal);
        }
    }
}
