using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._62_Switch_Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Command: ");
            int command = int.Parse(Console.ReadLine());

            switch (command)
            {
                case 1:
                    Console.WriteLine("Command 1 chosen");
                    break;
                case 2:
                    Console.WriteLine("Command 2 chosen");
                    break;
                case 3:
                    Console.WriteLine("Command 3 chosen");
                    break;
                default:
                    Console.WriteLine("Please enter a command from range 1-3");
                    break;
            }
            Console.ReadKey();
        }
    }
}
