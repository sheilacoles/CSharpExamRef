using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._41_GetEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get an enumerator that can iterate through a string
            var stringEnumerator = "Hello world".GetEnumerator();

            while (stringEnumerator.MoveNext())
                Console.Write(stringEnumerator.Current);
            Console.ReadKey();
        }
    }
}
