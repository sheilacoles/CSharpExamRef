using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace _3._14_AES_Encryption
{
    class Program
    {
        static void DumpBytes(string title, byte[] bytes)
        {
            Console.Write(title);
            foreach (byte b in bytes)
                Console.Write("{0:X}", b);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string plainText = "This is my super secret data";

            //byte array to hold the encrypted message
            byte[] cipherText;

            //byte array to hold the key that was used for encryption
            byte[] key;

            //byte array to hold initialization vector that was used for encryption
            byte[] initializationVector;

            //Create an Aes instance
            //this creates a random key and initialization vector

            using (Aes aes = Aes.Create())
            {
                //copy the key and initialization vector
                key = aes.Key;
                initializationVector = aes.IV;

                //create an encryptor to encrypt some data
                //should be wrapped in using for production code
                ICryptoTransform encryptor = aes.CreateEncryptor();

                //Create a new memory stream to receive the encrypted data
                using (MemoryStream encryptMemoryStream = new MemoryStream())
                {
                    //create a CryptoStream
                    //tell it the stream to write to, the encryptor to use, set the mode
                    using (CryptoStream encryptCryptoStream = 
                        new CryptoStream(encryptMemoryStream, encryptor,
                        CryptoStreamMode.Write))
                    {
                        //make a stream writer from the cryptostream
                        using (StreamWriter swEncrypt = 
                            new StreamWriter(encryptCryptoStream))
                        {
                            //write the secret message to the stream
                            swEncrypt.Write(plainText);
                        }
                        //get the encrypted message from the stream
                        cipherText = encryptMemoryStream.ToArray();
                    }
                    
                }
            }

            //Dump out datta
            Console.WriteLine("String to encrypt: {0}", plainText);
            DumpBytes("Key: ", key);
            DumpBytes("Initialization Vector: ", initializationVector);
            DumpBytes("Encrypted:", cipherText);

            Console.ReadKey();
        }
    }
}
