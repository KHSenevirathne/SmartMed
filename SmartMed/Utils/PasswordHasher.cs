using System;
using System.Security.Cryptography;
using System.Text;

namespace SmartMed.Utils
{
    // Unsalted SHA-256 - sufficient for this coursework's scope, but not production-grade (no per-user salt, no key stretching).
    public static class PasswordHasher
    {
        public static string Hash(string password)
        {
            if (password == null)
            {
                password = string.Empty;
            }

            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool Verify(string password, string expectedHash)
        {
            if (string.IsNullOrEmpty(expectedHash))
            {
                return false;
            }

            string actual = Hash(password);
            return string.Equals(actual, expectedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
