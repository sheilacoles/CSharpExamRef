using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._21_Checksums
{
    class Program
    {
        static int CalculateChecksum (string source)
        {
            int total = 0;
            foreach (char ch in source)
                total = total + (int)ch;
            return total;
        }
        static void ShowChecksum(string source)
        {
            Console.WriteLine("Checksum for {0} is {1}", source, CalculateChecksum(source));
        }
        static void Main(string[] args)
        {
            ShowChecksum("Hello world");
            ShowChecksum("world Hello");
            ShowChecksum("Hemmm world");

            Console.ReadKey();
        }
    }
}
