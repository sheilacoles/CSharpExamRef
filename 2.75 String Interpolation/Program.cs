using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._75_String_Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Rob";
            int age = 21;
            Console.WriteLine("Your name is {0} and your age is {1,-5:D}", name, age);

            Console.WriteLine($"Your name is {name} and your age is {age,-5:D}");

            Console.WriteLine(String.Format($"Your name is {name} and your age is {age,-5:D}"));

            double bankBalance = 123.45;
            FormattableString balanceMessage = $"US balance : {bankBalance:C}";
            CultureInfo usProvider = new CultureInfo("en-US");
            Console.WriteLine(balanceMessage.ToString(usProvider));

            Console.ReadKey();
        }
    }
}
