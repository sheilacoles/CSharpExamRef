using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._1_DirectoryInfo_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo localDir = new DirectoryInfo("TestDir");

            localDir.Create();

            if (localDir.Exists)
                Console.WriteLine("Directory created successfully");

            localDir.Delete();
            Console.WriteLine("Directory deleted successfully");
        }
    }
}
