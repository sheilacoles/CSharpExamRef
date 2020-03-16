using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._54_For_Loop
{
    class Program
    {
        static int counter;
        static void Initialize()
        {
            Console.WriteLine("Initialize called");
            counter = 0;
        }
        static void Update()
        {
            Console.WriteLine("Update called");
            counter = counter + 1;
        }
        static bool Test()
        {
            Console.WriteLine("Test called");
            return counter < 5;
        }
        static void Main(string[] args)
        {
            for (Initialize(); Test(); Update())
            {
                Console.WriteLine("Hello {0}", counter);
            }

            for (int counter = 0; counter < 5; counter++)
                Console.WriteLine("Hello {0}", counter);

            Console.ReadKey();
        }
    }
}
