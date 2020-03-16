using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._13_Extension_Method
{
    public static class MyExtensions
    {
        public static int LineCount(this String str)
        {
            return str.Split(new char[] { '\n' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"A rocket explorer called Wright,
Once travelled much faster than light,
He set out one day,
In a relative way,
And returned on the previous night";

            Console.WriteLine(text.LineCount());
            Console.ReadKey();
        }
    }
}
