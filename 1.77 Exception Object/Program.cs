using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._77_Exception_Object
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
            catch(Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Stacktrace: " + ex.StackTrace);
                Console.WriteLine("Helplink: " + ex.HelpLink);
                Console.WriteLine("Targetsite: " + ex.TargetSite);
                Console.WriteLine("Source: " + ex.Source);
            }
            Console.ReadKey();
        }
    }
}
