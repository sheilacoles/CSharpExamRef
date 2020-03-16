using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._28_Adding_Diagnostics
{
    public class MusicTrack
    {
        public static bool DebugMode = false;

        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }

        //ToString that overrides the behaviour in the base class
        public override string ToString()
        {
            return Artist + " " + Title + " " + Length.ToString() + " seconds long";
        }

        public MusicTrack(string artist, string title, int length)
        {
            Artist = artist;
            Title = title;
            Length = length;
            if (DebugMode)
                Console.WriteLine("Music track created: {0}", this.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MusicTrack.DebugMode = true;

            MusicTrack m = new MusicTrack(artist: "Rob Miles", title: "My Way", length: 150);

            Console.ReadKey();
        }
    }
}
