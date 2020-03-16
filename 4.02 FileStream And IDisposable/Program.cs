using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._02_FileStream_And_IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream outputStream = new FileStream("OutputText.txt",
                FileMode.OpenOrCreate, FileAccess.Write))
            {
                string outputMessageString = "Hello world";
                byte[] outputMessageBytes = Encoding.UTF8.GetBytes(outputMessageString);
                outputStream.Write(outputMessageBytes, 0, outputMessageBytes.Length);
            }
        }
    }
}
