using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3._08_Validate_Music_Track
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Rob Miles:My Way:120";

            string regexToMatch = ".+:.+:.+";

            if (Regex.IsMatch(input, regexToMatch))
                Console.WriteLine("Valid music track description");
            Console.ReadKey();
        }
    }
}
