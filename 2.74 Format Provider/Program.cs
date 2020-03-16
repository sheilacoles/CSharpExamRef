using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._74_Format_Provider
{
    class Program
    {
        static void Main(string[] args)
        {
            double bankBalance = 123.45;
            CultureInfo usProvider = new CultureInfo("en-US");
            Console.WriteLine("US balance: {0}", bankBalance.ToString("C", usProvider));

            CultureInfo ukProvider = new CultureInfo("en-GB");
            Console.WriteLine("UK balance: {0}", bankBalance.ToString("C", ukProvider));

            Console.ReadKey();
        }
    }
}
