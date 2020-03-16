using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._59_Word_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> counters = new Dictionary<string, int>();

            string text = File.ReadAllText("input.txt");

            string[]words = text.Split(new char[] { ' ','.',','},
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                string lowWord = word.ToLower();
                if (counters.ContainsKey(lowWord))
                    counters[lowWord]++;
                else
                    counters.Add(lowWord, 1);
            }

            //Dictionary class does not provide a Sort behaviour
            //Use LINQ query to produce a sorted iteration of the dictionary contents

            var items = from pair in counters
                        orderby pair.Value descending
                        select pair;

            foreach (var pair in items)
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);

            Console.ReadKey();
        }
    }
}
