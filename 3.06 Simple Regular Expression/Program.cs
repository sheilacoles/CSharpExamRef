using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3._06_Simple_Regular_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Rob Mary David Jenny Chris Imogen Rodney";

            string regularExpressionToMatch = " ";
            string patternToReplace = ",";

            string replaced = Regex.Replace(input, regularExpressionToMatch, 
                patternToReplace);
            Console.WriteLine(replaced);
            Console.ReadKey();
        }
    }
}
