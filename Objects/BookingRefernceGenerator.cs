using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace aero_quest.Objects
{
    public class BookingReferenceGenerator
    {
        // Generates a cryptographically secure random booking reference of a specified length (default is 10).
        public static string GenerateBookingReference(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder reference = new StringBuilder();

            // Use RNGCryptoServiceProvider to generate cryptographically secure random bytes
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[length];
                rng.GetBytes(randomBytes); // Fill the byte array with random values

                // Map the random bytes to the alphanumeric character set
                for (int i = 0; i < length; i++)
                {
                    int index = randomBytes[i] % chars.Length;
                    reference.Append(chars[index]);
                }
            }

            return reference.ToString();
        }
    }
}
