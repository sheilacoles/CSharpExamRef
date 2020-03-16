using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _3._19_Machine_Level_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "Machine Level Key";

            //Specify that the key is to be stored in the machine level key store
            cspParams.Flags = CspProviderFlags.UseMachineKeyStore;

            //Create a crypto service provider
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspParams);

            Console.WriteLine(rsa.ToXmlString(includePrivateParameters: false));

            //Make sure it is persisting keys
            rsa.PersistKeyInCsp = true;

            //Clear the provider to make sure it saves the key
            rsa.Clear();
        }
    }
}
