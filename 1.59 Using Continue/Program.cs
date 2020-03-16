using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._59_Using_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Rob", "Mary", "David", "Jenny", "Chris", "Imogen" };

            for (int index = 0; index < names.Length; index++)
            {
                if (names[index] == "David")
                    continue;
                Console.WriteLine(names[index]);
            }
            Console.ReadKey();
        }
    }
}
