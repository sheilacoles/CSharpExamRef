using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._52_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true) { Console.WriteLine("Hello"); }
            //while (false) { Console.WriteLine("Hello"); }

            //Prints message 10 times
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine("Hello {0}", count);
                count = count + 1;
            }

            //Construction consumes data while it is available
            while(dataAvailable())
            {
                processData();
            }
        }
    }
}
