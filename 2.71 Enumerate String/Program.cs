using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._71_Enumerate_String
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (char ch in "Hello World")
            {
                Console.WriteLine(ch);
            }
            Console.ReadKey();
        }
    }
}
