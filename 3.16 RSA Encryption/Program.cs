using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _3._16_RSA_Encryption
{
    class Program
    {
        static void DumpBytes(string title, byte[] bytes)
        {
            Console.Write(title);
            foreach (byte b in bytes)
            {
                Console.Write("{0:X}", b);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string plainText = "This is my super secret data";
            Console.WriteLine("Plain text: {0}", plainText);

            //RSA works on byte arrays, not strings of text
            //This will convert our input string into bytes and back

            ASCIIEncoding converter = new ASCIIEncoding();

            //Convert the plain text into a byte array

            byte[] plainBytes = converter.GetBytes(plainText);

            DumpBytes("Plain bytes: {0}", plainBytes);

            byte[] encryptedBytes;
            byte[] decryptedBytes;

            //Create a new RSA to encrypt the data
            //should be wrapped in using for production code
            RSACryptoServiceProvider rsaEncrypt = new RSACryptoServiceProvider();

            //Get keys out of the encryptor
            string publicKey = rsaEncrypt.ToXmlString(includePrivateParameters: false);
            Console.WriteLine("Public key: {0}", publicKey);

            string privateKey = rsaEncrypt.ToXmlString(includePrivateParameters: true);
            Console.WriteLine("Private key: {0}", privateKey);

            //Now tell the encryptor to use the public key to encrypt the data
            rsaEncrypt.FromXmlString(privateKey);

            //Use the encryptor to encrypt the data
            //The fOAEP parameter specifies how the output is "padded" with extra bytes
            //For maximum compatibility with receiving systems, set this as false
            encryptedBytes = rsaEncrypt.Encrypt(plainBytes, fOAEP: false);

            DumpBytes("Encrypted bytes: {0}", encryptedBytes);

            //Now do the decode - use the private key for this
            //We have sent someone our public key 
            //And they have used this to encrypt the data that they are sending to us

            //Create a new RSA to decrypt the data
            //should be wrapped in using for production code
            RSACryptoServiceProvider rsaDecrypt = new RSACryptoServiceProvider();

            //Configure the decryptor from the XML in the private key
            rsaDecrypt.FromXmlString(privateKey);

            decryptedBytes = rsaDecrypt.Decrypt(encryptedBytes, fOAEP: false);

            DumpBytes("Decrypted bytes: {0}", decryptedBytes);
            Console.WriteLine("Decrypted string: {0}",
                converter.GetString(decryptedBytes));

            Console.ReadKey();
        }
    }
}
