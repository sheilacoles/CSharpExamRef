using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._22_Hashing
{
    class Program
    {
        static void ShowHash(object source)
        {
            Console.WriteLine("Hash for {0} is: {1:X}", source, source.GetHashCode());
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
