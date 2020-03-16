using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3._18_RSA_Stored_Key_Clear
{
    class Program
    {
        static void Main(string[] args)
        {
            string containerName = "My Key Store";

            CspParameters csp = new CspParameters();
            csp.KeyContainerName = containerName;

            RSACryptoServiceProvider rsaStore = new RSACryptoServiceProvider(csp);

            //To delete a stored key
            rsaStore.PersistKeyInCsp = false;
            rsaStore.Clear();

            RSACryptoServiceProvider rsaLoad = new RSACryptoServiceProvider(csp);
            Console.WriteLine("Loaded keys: {0}",
                rsaLoad.ToXmlString(includePrivateParameters: true));

            Console.ReadKey();

        }
    }
}
