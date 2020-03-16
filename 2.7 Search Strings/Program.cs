using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Globalization;

namespace _2._7_Search_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "      Rob Miles";

            if (input.Contains("Rob"))
            {
                Console.WriteLine("Input contains Rob");
            }

            string trimmedString = input.TrimStart();
            if (trimmedString.StartsWith("Rob"))
            {
                Console.WriteLine("Starts with Rob");
            }

            int nameStart = input.IndexOf("Rob");
            string name = input.Substring(nameStart, 3);
            Console.WriteLine(name);

            string informalString = "Rob Miles";
            string formalString = informalString.Replace("Rob", "Robert");
            Console.WriteLine(formalString);

            string sentence = "The cat sat on the mat.";
            string[] words = sentence.Split(' ');
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            //Default comparison fails because the strings are different
            if (!"encyclopædia".Equals("encyclopaedia"))
                Console.WriteLine("Unicode encyclopaedias are not equal");

            //Set the current culture for this thread to EN-US
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            //Using the current culture the strings are equal
            if ("encyclopædia".Equals("encyclopaedia", StringComparison.CurrentCulture))
                Console.WriteLine("Culture comparison encyclopaedias are equal");

            //We can use the IgnoreCase option to perform comparisons that ignore case
            if ("encyclopædia".Equals("ENCYCLOPAEDIA", StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine("Case culture comparisons encyclopaedias are equal");

            if (!"encyclopædia".Equals("ENCYCLOPAEDIA", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Ordinal encyclopaedias are not equal");

            Console.ReadKey();
        }
    }
}
