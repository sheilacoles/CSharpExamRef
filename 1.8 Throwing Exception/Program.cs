using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_Throwing_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception(
                    "I think you should know that I'm feeling very depressed.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Something bad happened", ex);
            }
        }
    }
}
