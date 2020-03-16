using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._06_Stream_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string contents = File.ReadAllText(path: "TestFile.txt");
                Console.WriteLine(contents);
            }
            catch(FileNotFoundException notFoundEx)
            {
                //File not found
                Console.WriteLine(notFoundEx.Message);
            }
            catch(Exception ex)
            {
                //Any other exception
                Console.WriteLine(ex.Message);
            }
        }
    }
}
