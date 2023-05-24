using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Utilitarios
{
    public class Password
    {
        public static string ComputeHash(string password, byte[]? salt = null)
        {
            byte[]? saltBytes;
            if (salt != null)
            {
                saltBytes = salt;
            }
            else
            {
                Random r = new();
                int saltLength = r.Next(4, 16);
                saltBytes = new byte[saltLength];
                using var rng = RandomNumberGenerator.Create();
                rng.GetNonZeroBytes(saltBytes);
            }
            byte[] plainData = ASCIIEncoding.UTF8.GetBytes(password);
            byte[] plainDataWithSalt = new byte[plainData.Length + saltBytes.Length];

            Buffer.BlockCopy(plainData, 0, plainDataWithSalt, 0, plainData.Length);
            Buffer.BlockCopy(saltBytes, 0, plainDataWithSalt, plainData.Length, saltBytes.Length);
            byte[]? hashValue = SHA512.HashData(plainDataWithSalt);
            byte[] result = new byte[hashValue.Length + saltBytes.Length];

            Buffer.BlockCopy(hashValue, 0, result, 0, hashValue.Length);
            Buffer.BlockCopy(saltBytes, 0, result, hashValue.Length, saltBytes.Length);

            return Convert.ToBase64String(result);
        }

        public static bool ConfirmHash(string plainText, string hashValue)
        {
            byte[] hashBytes = Convert.FromBase64String(hashValue);
            byte[] saltBytes = new byte[hashBytes.Length - 64];

            Buffer.BlockCopy(hashBytes, 64, saltBytes, 0, saltBytes.Length);
            string newHash = ComputeHash(plainText, saltBytes);

            return (hashValue == newHash);
        }
    }
}
