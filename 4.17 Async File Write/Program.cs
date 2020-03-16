using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._17_Async_File_Write
{
    class Program
    {
        static void Main(string[] args)
        {
            async Task WriteBytesAsync(string filename, byte[] items)
            {
                using (FileStream outStream = new FileStream (filename, 
                    FileMode.OpenOrCreate, FileAccess.Write))
                {
                    await outStream.WriteAsync(items, 0, items.Length);
                }
            }
        }
    }
}
