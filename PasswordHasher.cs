using System;

namespace AppointmentUI
{
    /// <summary>
    /// Utility class for hashing and verifying passwords using BCrypt.
    /// </summary>
    public static class PasswordHasher
    {
        /// <summary>
        /// Hashes a plain text password using BCrypt.
        /// </summary>
        /// <param name="password">The plain text password to hash.</param>
        /// <returns>The BCrypt hash of the password.</returns>
        public static string HashPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password cannot be null or empty.", nameof(password));
            }

            // Generate a salt and hash the password
            // BCrypt automatically generates a salt and includes it in the hash
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        /// <summary>
        /// Verifies a plain text password against a BCrypt hash.
        /// </summary>
        /// <param name="password">The plain text password to verify.</param>
        /// <param name="hash">The BCrypt hash to verify against.</param>
        /// <returns>True if the password matches the hash; otherwise, false.</returns>
        public static bool VerifyPassword(string password, string hash)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(hash))
            {
                return false;
            }

            try
            {
                // Verify the password against the hash
                return BCrypt.Net.BCrypt.Verify(password, hash);
            }
            catch
            {
                // If verification fails for any reason, return false
                return false;
            }
        }
    }
}
