using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._08_Using_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "TextFile.txt";

            File.WriteAllText(path: filePath, contents: "This text goes in the file");
            FileInfo info = new FileInfo(filePath);

            Console.WriteLine("Name: {0}", info.Name);
            Console.WriteLine("Full Path: {0}", info.FullName);
            Console.WriteLine("Last Access: {0}", info.LastAccessTime);
            Console.WriteLine("Length: {0}", info.Length);
            Console.WriteLine("Attributes: {0}", info.Attributes);

            info.Attributes |= FileAttributes.ReadOnly;
            Console.WriteLine("Attributes: {0}", info.Attributes);
            Console.WriteLine("Remove the readonly attribute");
            info.Attributes &= ~FileAttributes.ReadOnly;
            Console.WriteLine("Attributes: {0}", info.Attributes);




        }
    }
}
