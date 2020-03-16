using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._21_Boxing_And_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //the value 99 is boxed into an object
            object o = 99;

            //the boxed object is unboxed back into an int
            int oVal = (int)o;
            Console.WriteLine(oVal);
            Console.ReadKey();
        }
    }
}
