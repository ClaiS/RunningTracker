using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Services.Helpers
{
    public static class PasswordHelper
    {
        private const int SaltSize = 16;      // 128 bit
        private const int HashSize = 20;      // 160 bit
        private const int Iterations = 10000; // số vòng lặp

        public static string HashPassword(string password)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var salt = new byte[SaltSize];
                rng.GetBytes(salt);

                var hash = new Rfc2898DeriveBytes(password, salt, Iterations);
                var hashBytes = hash.GetBytes(HashSize);

                var hashWithSalt = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashWithSalt, 0, SaltSize);
                Array.Copy(hashBytes, 0, hashWithSalt, SaltSize, HashSize);

                return Convert.ToBase64String(hashWithSalt);
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            var hashWith_salt = Convert.FromBase64String(hashedPassword);
            if (hashWith_salt.Length != SaltSize + HashSize)
                return false;

            var salt = new byte[SaltSize];
            Array.Copy(hashWith_salt, 0, salt, 0, SaltSize);

            var hash = new Rfc2898DeriveBytes(password, salt, Iterations);
            var hashBytes = hash.GetBytes(HashSize);

            for (int i = 0; i < HashSize; i++)
            {
                if (hashWith_salt[i + SaltSize] != hashBytes[i])
                    return false;
            }
            return true;
        }
    }
}
