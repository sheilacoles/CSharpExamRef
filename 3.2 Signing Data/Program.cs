using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace _3._2_Signing_Data
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
            //This will convert our inout string into bytes and back
            ASCIIEncoding converter = new ASCIIEncoding();

            //Get a crypto provider out of the certificate store
            //should be wrapped in using for production code
            X509Store store = new X509Store("demoCertStore", StoreLocation.CurrentUser);

            store.Open(OpenFlags.ReadOnly);

            //should be wrapped in using for production code
            X509Certificate2 certificate = store.Certificates[0];

            //should be wrapped in using for production code
            RSACryptoServiceProvider encryptProvider =
                certificate.PrivateKey as RSACryptoServiceProvider;

            string messageToSign = "This is the message I wasnt to sign";
            Console.WriteLine("Message: {0}", messageToSign);

            byte[] messageToSignBytes = converter.GetBytes(messageToSign);
            DumpBytes("Message to sign in bytes: {0}", messageToSignBytes);

            //need to calculate a hash for this message - this will go into the 
            //signature and be used to verify the message
            //Create an implementation of the hashing algorithm we are going to use
            //should be wrapped in using for production code
            HashAlgorithm hasher = new SHA1Managed();
            //Use the hasher to hash the message
            byte[] hash = hasher.ComputeHash(messageToSignBytes);
            DumpBytes("Hash for message: {0}", hash);

            //Now sign the hash to create a signature
            byte[] signature = encryptProvider.SignHash(hash, CryptoConfig.
                MapNameToOID("SHA1"));
            DumpBytes("Signature: {0}", messageToSignBytes);

            //We can send the signature along with the message to authenticate it
            //Create a decryptor that uses the public key
            //Should be wrapped in using for production code
            RSACryptoServiceProvider decryptProvider =
                certificate.PublicKey.Key as RSACryptoServiceProvider;

            //Now use the signature to perform a successful validation of the message
            bool validSignature = decryptProvider.VerifyHash(hash,
                CryptoConfig.MapNameToOID("SHA1"), signature);
            Console.WriteLine("Correct signature validated OK: {0}", validSignature);

            //Change one byte of the signature
            signature[0] = 99;
            //Now try the using the incorrect signature to validate the message
            bool invalidSignature = decryptProvider.VerifyHash(hash,
                CryptoConfig.MapNameToOID("SHA1"), signature);
            Console.WriteLine("Incorrect signature validated OK: {0}", invalidSignature);

            Console.ReadKey();
        }
    }
}
