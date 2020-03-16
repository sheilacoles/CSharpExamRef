using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStorage;

namespace _3._26_Strong_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string assemblyName = typeof(MusicTrack).Assembly.FullName;
            Console.WriteLine(assemblyName);
            Console.ReadKey();
        }
    }
}
