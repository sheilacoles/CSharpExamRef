//#undef DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._3_Conditional_Attribute
{
    class Program
    {
        [Conditional("DEBUG")]
        static void display(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            display("Message for user");
            Console.ReadKey();
        }
    }
}
