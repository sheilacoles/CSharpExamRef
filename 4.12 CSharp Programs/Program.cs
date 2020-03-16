using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._12_CSharp_Programs
{
    class Program
    {
        static void FindFiles(DirectoryInfo dir, string searchPattern)
        {
            foreach (DirectoryInfo directory in dir.GetDirectories())
                FindFiles(directory, searchPattern);

            FileInfo[] matchingFiles = dir.GetFiles(searchPattern);
            foreach (FileInfo fileInfo in matchingFiles)
                Console.WriteLine(fileInfo.FullName);
        }
        static void Main(string[] args)
        {
            DirectoryInfo startDir = new DirectoryInfo(@"..\..\..\..");
            string searchString = "*.cs";

            FindFiles(startDir, searchString);

            Console.ReadKey();
        }
    }
}
