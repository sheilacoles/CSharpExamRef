using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._42_Using_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (char ch in "Hello world")
                Console.Write(ch);
            Console.ReadKey();
        }
    }
}
