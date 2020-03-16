using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._62_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> demoStack = new Stack<string>();

            demoStack.Push("Rob Miles");
            demoStack.Push("Immy Brown");

            Console.WriteLine(demoStack.Pop());
            Console.WriteLine(demoStack.Pop());

            Console.ReadKey();
        }
    }
}
