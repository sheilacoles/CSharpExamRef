using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _3._23_SHA2
{
    class Program
    {
        static byte[] CalculateHash(string source)
        {
            //this will convert input string into bytes and back
            ASCIIEncoding converter = new ASCIIEncoding();
            byte[] sourceBytes = converter.GetBytes(source);

            HashAlgorithm hasher = SHA256.Create();
            byte[] hash = hasher.ComputeHash(sourceBytes);
            return hash;
        }
        static void ShowHash(string source)
        {
            Console.Write("Hash for {0} is: ", source);
            byte[] hash = CalculateHash(source);
            foreach (byte b in hash)
                Console.Write("{0:X} ", b);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ShowHash("Hello world");
            ShowHash("world Hello");
            ShowHash("Hemmm world");

            Console.ReadKey();
        }
    }
}
