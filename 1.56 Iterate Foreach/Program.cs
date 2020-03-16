using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._56_Iterate_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Rob", "Mary", "David", "Jenny", "Chris", "Imogen" };

            //Type of iterating value must match type of items in collection
            //Not possible to modify interating value in a foreach construction
            foreach (string name in names)
                Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
