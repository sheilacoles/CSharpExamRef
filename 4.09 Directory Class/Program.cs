using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._09_Directory_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("TestDir");

            if (Directory.Exists("TestDir"))
                Console.WriteLine("Directory created successfully");

            Directory.Delete("TestDir");

            Console.WriteLine("Directory deleted successfully");
        }
    }
}
