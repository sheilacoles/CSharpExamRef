using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._11_Using_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = @"c:\Users\Sheila\Documents\Desktop\Others\test.txt";

            string dirName = Path.GetDirectoryName(fullName);
            string fileName = Path.GetFileName(fullName);
            string fileExtension = Path.GetExtension(fullName);
            string lisName = Path.ChangeExtension(fullName, ".lis");
            string newTest = Path.Combine(dirName, "newtest.txt");

            Console.WriteLine("Full name: {0}", fullName);
            Console.WriteLine("File directory: {0}", dirName);
            Console.WriteLine("File name: {0}", fileName);
            Console.WriteLine("File extension: {0}", fileExtension);
            Console.WriteLine("File with lis extension: {0}", lisName);
            Console.WriteLine("New test: {0}", newTest);

            Console.ReadKey();
        }
    }
}
