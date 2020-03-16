using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._83_Inner_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter an integer: ");
                    string numberText = Console.ReadLine();
                    int result;
                    result = int.Parse(numberText);
                }
                catch(Exception ex)
                {
                    throw new Exception("Calculator failure", ex);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
