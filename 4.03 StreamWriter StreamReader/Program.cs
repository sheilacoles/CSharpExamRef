using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._03_StreamWriter_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writeStream = new StreamWriter("OutputText.txt"))
            {
                writeStream.Write("Hello World");
            }
            using(StreamReader readStream=new StreamReader("OutputText.txt"))
            {
                string readString = readStream.ReadToEnd();
                Console.WriteLine("Text read: {0}", readString);
            }
            Console.ReadKey();
        }
    }
}
