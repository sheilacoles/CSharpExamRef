using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace _3._24_Encrypt_Stream
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
            string plainText = "This is my super duper secret data";

            byte[] encryptedText;
            byte[] key1;
            byte[] key2;
            byte[] initializationVector1;
            byte[] initializationVector2;

            using (Aes aes1 = Aes.Create())
            {
                key1 = aes1.Key;
                initializationVector1 = aes1.IV;
                aes1.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor1 = aes1.CreateEncryptor();

                using(MemoryStream encryptMemoryStream=new MemoryStream())
                {
                    using (CryptoStream cryptoStream1 = new CryptoStream(encryptMemoryStream,
                        encryptor1, CryptoStreamMode.Write))
                    {
                        //Add another layer of encryption
                        using (Aes aes2 = Aes.Create())
                        {
                            key2 = aes2.Key;
                            initializationVector2 = aes2.IV;
                            aes2.Padding = PaddingMode.PKCS7;

                            ICryptoTransform encryptor2 = aes2.CreateEncryptor();

                            using (CryptoStream cryptoStream2 = new CryptoStream(
                                cryptoStream1, encryptor2, CryptoStreamMode.Write))
                            {
                                using (StreamWriter swEncrypt= new StreamWriter(cryptoStream2))
                                {
                                    swEncrypt.Write(plainText);
                                }
                                encryptedText = encryptMemoryStream.ToArray();
                            }
                        }
                    }
                }
            }

            //Decryption
            string decryptedText;

            using (Aes aes2= Aes.Create())
            {
                aes2.Key = key2;
                aes2.IV= initializationVector2;
                aes2.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor1 = aes2.CreateDecryptor();

                using(MemoryStream decryptMemoryStream=new MemoryStream(encryptedText))
                {
                    using (CryptoStream cryptoStream1 = new CryptoStream(
                        decryptMemoryStream, decryptor1, CryptoStreamMode.Read))
                    {
                        //Another layer
                        using (Aes aes1 = Aes.Create())
                        {
                            aes1.Key = key1;
                            aes1.IV = initializationVector1;
                            aes1.Padding = PaddingMode.PKCS7;

                            ICryptoTransform decryptor2 = aes1.CreateDecryptor();

                            using (CryptoStream cryptoStream2 = new CryptoStream(
                                cryptoStream1, decryptor2, CryptoStreamMode.Read))
                            {
                                using (StreamReader srDecrypt = new StreamReader(
                                    cryptoStream2))
                                {
                                    decryptedText = srDecrypt.ReadToEnd();
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("String to encrypt: {0}", plainText);
            DumpBytes("Encrypted: {0}",encryptedText);
            Console.WriteLine(decryptedText);

            Console.ReadKey();
        }
    }
}
