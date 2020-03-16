using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._05_File_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(path: "TextFile.txt", contents: "This text goesin the file");
            File.AppendAllText(path: "TextFile.txt", contents: " - This goes on the end");

            if (File.Exists("TextFile.txt"))
                Console.WriteLine("Text file exists");

            string contents = File.ReadAllText(path: "TextFile.txt");
            Console.WriteLine("File Contents: {0}", contents);

            File.Copy(sourceFileName: "TextFile.txt", destFileName: "CopyTextFile.txt");

            using (TextReader reader = File.OpenText(path: "CopyTextFile.txt"))
            {
                string text = reader.ReadToEnd();
                Console.WriteLine("Copied text: {0}", text);
            }
        }
    }
}
