using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._33_Debug_Code_Tracing
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Starting the program");
            Debug.Indent();
            Debug.WriteLine("Inside a function");
            Debug.Unindent();
            Debug.WriteLine("Outside a function");
            string customerName = "Rob";
            Debug.WriteLineIf(string.IsNullOrEmpty(customerName), "The name is empty");

            Console.ReadKey();
        }
    }
}
