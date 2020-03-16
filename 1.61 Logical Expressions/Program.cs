using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._61_Logical_Expressions
{
    class Program
    {
        static int mOne()
        {
            Console.WriteLine("mOne called");
            return 1;
        }
        static int mTwo()
        {
            Console.WriteLine("mTwo called");
            return 2;
        }

        static void Main(string[] args)
        {
            if (mOne() == 2 && mTwo() == 1)
                Console.WriteLine("Hello world");

            Console.ReadKey();
        }
    }
}
