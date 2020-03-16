using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._57_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Rob Miles");
            names.Add("Immy Brown");

            for (int i = 0; i < names.Count; i++)
                Console.WriteLine(names[i]);

            names[0] = "Fred Blogs";
            foreach (string name in names)
                Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
