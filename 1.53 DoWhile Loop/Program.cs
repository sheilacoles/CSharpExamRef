using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._53_DoWhile_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Condition tested after block is performed once
            do
            {
                Console.WriteLine("Hello");
            }
            while (false);

            //Code to continuously fetch data until valid value is entered
            do
            {
                requestData();
            }
            while (!dataValid());
        }
    }
}
