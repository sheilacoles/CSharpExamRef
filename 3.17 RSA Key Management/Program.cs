using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _3._17_RSA_Key_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            string containerName = "My Key Store";

            CspParameters csp = new CspParameters();
            csp.KeyContainerName = containerName;

            //Create a new RSA to encrypt to data
            RSACryptoServiceProvider rsaStore = new RSACryptoServiceProvider(csp);
            Console.WriteLine("Stored keys: {0}",
                rsaStore.ToXmlString(includePrivateParameters: true));

            RSACryptoServiceProvider rsaLoad = new RSACryptoServiceProvider(csp);
            Console.WriteLine("Loaded keys: {0}",
                rsaLoad.ToXmlString(includePrivateParameters: true));

            Console.ReadKey();
        }
    }
}
