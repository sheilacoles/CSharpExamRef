using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2._69_StringReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataString = 
                @"Rob Miles 
                21";

            StringReader dataStringReader = new StringReader(dataString);

            string name = dataStringReader.ReadLine();
            int age = int.Parse(dataStringReader.ReadLine());

            dataStringReader.Close();

            Console.WriteLine("Name: {0} Age:{1}", name, age);
            Console.ReadKey();
        }
    }
}
