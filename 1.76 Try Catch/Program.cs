using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._76_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer: ");
                string numberText = Console.ReadLine();
                int result;
                result = int.Parse(numberText);
                Console.WriteLine("You entered {0}", result);
            }
            catch
            {
                Console.WriteLine("Invalid number entered");
            }
            Console.ReadKey();
        }
    }
}
