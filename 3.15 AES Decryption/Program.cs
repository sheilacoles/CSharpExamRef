using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace _3._15_AES_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = "This is my super secret data";

            byte[] cipherText;
            byte[] key;
            byte[] initializationVector;

            using (Aes aes = Aes.Create())
            {
                key = aes.Key;
                initializationVector = aes.IV;

                ICryptoTransform encryptor = aes.CreateEncryptor();

                using (MemoryStream encryptMemoryStream = new MemoryStream())
                {
                    using (CryptoStream encryptCryptoStream =
                        new CryptoStream(encryptMemoryStream,
                        encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter
                            (encryptCryptoStream))
                        {
                            swEncrypt.Write(plainText);
                        }
                        cipherText = encryptMemoryStream.ToArray();
                    }
                }

            }

            //Decryptiion
            string decryptedText;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = initializationVector;

                ICryptoTransform decryptor = aes.CreateDecryptor();

                using (MemoryStream decryptStream = new MemoryStream(cipherText))
                {
                    using (CryptoStream decryptCryptoStream = new CryptoStream(
                        decryptStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(
                            decryptCryptoStream))
                        {
                            decryptedText = srDecrypt.ReadToEnd();

                        }
                    }
                }
            }

            Console.WriteLine(decryptedText);
            Console.ReadKey();
        }
    }
}
