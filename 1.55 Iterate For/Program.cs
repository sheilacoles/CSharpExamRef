﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._55_Iterate_For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Rob", "Mary", "David", "Jenny", "Chris", "Imogen" };

            for (int index = 0; index < names.Length; index++)
                Console.WriteLine(names[index]);
            Console.ReadKey();
        }

    }
}
