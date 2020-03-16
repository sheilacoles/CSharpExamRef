using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._15_Optional_Parameters
{
    class Program
    {
        static int ReadValue(
            double low,         //lowest allowed value
            double high,        //highest allowed value
            string prompt=""   //optional prompt for the user
            )
        {
            //method body
            return 0;
        }

        static void Main(string[] args)
        {
            var x = ReadValue(25,100);
        }
    }
}
