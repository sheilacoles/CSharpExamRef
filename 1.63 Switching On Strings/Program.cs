using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._63_Switching_On_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Command: ");
            string commandName = Console.ReadLine().ToLower();

            switch (commandName)
            {
                case "save":
                case "s":
                    Console.WriteLine("Save command");
                    break;
                case "load":
                case "l":
                    Console.WriteLine("Load command");
                    break;
                case "exit":
                case "e":
                    Console.WriteLine("Exit command");
                    break;
                default:
                    Console.WriteLine("please enter save, load or exit");
                    break;
            }
            Console.ReadKey();
        }
    }
}
