using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2._68_StringWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWriter writer = new StringWriter();
            writer.WriteLine("Hello World");
            writer.Close();
            Console.Write(writer.ToString());
            Console.ReadKey();
        }
    }
}
