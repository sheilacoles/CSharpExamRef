﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._63_Collection_Initialization
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInit = { 1, 2, 3, 4 };

            ArrayList arrayListInit = new ArrayList { 1, "Rob Miles", new ArrayList() };

            List<int> listInit = new List<int> { 1, 2, 3, 4 };

            Dictionary<int, string> dictionaryInit = new Dictionary<int, string>
            {
                {1,"Rob" },
                {2,"Immy" }
            };

            HashSet<string> setInit = new HashSet<string> { "Electronic", "Disco", "Fast" };

            Queue<string> queueInit = new Queue<string>(new string[] { "Rob", "Immy" });

            Stack<string> stackInit = new Stack<string>(new string[] { "Rob", "Immy" });

        }
    }
}
