using MusicStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._25_Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicTrack m = new MusicTrack(artist: "Rob Miles", 
                title: "My Way", length: 150);
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
