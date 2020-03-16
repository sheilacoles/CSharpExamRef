using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._72_Format_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 99;
            double pi = 3.141592654;

            Console.WriteLine(" {0,-10:D}{0,-10:X}{1,5:N2}", i, pi);
            Console.ReadKey();
        }
    }
}
