using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._04_Storing_Compressed_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream writeFile = new FileStream("CompText.zip", 
                FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (GZipStream writeFileZip = new GZipStream(writeFile,
                    CompressionMode.Compress))
                {
                    using (StreamWriter writeFileText = new StreamWriter(writeFileZip))
                    {
                        writeFileText.Write("Hello world");
                    }
                }
            }
            using (FileStream readFile = new FileStream("CompText.zip",
                FileMode.Open, FileAccess.Read))
            {
                using(GZipStream readFileZip = new GZipStream(readFile,
                    CompressionMode.Decompress))
                {
                    using (StreamReader readFileText=new StreamReader(readFileZip))
                    {
                        string message = readFileText.ReadToEnd();
                        Console.WriteLine("Read text: {0}", message);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
