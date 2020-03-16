using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._64_Expression_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; //create i and set to 0

            //Monadic operators - one operand
            i++; //monadic ++ operator increment - i now 1
            i--; //monadic --operator decrement - i now 0

            //postfic monadic operator -perform after value givewn
            Console.WriteLine(i++); //writes 0 and set i to 1
            //prefic monadic operator -perform before value given
            Console.WriteLine(++i); //writes 2 and sets i to 2

            //binary operators - two operands
            i = 1 + 1; //sets i to 2
            i = 1 + 2 * 3; //sets i to 7
            i = (1 + 2) * 3; //sets i to 9

            string str = "";
            str = str + "Hello"; //+ performs string addition

            //ternary operators - 3 operands
            i = true ? 0 : 1; //sets i to 0 because condition is true

        }
    }
}
