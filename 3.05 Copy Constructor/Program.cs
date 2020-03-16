using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._05_Copy_Constructor
{
    class MusicTrack
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }

        //Copy Constructor for MusicTrack
        public MusicTrack(MusicTrack source)
        {
            Artist = source.Artist;
            Title = source.Title;
            Length = source.Length;
        }
        public MusicTrack(string artist, string title, int length)
        {
            Artist = artist;
            Title = title;
            Length = length;
        }
    }
    class Program
    {
        //Naughty PrintTrack method that changes the Artist property 
        static void PrintTrack(MusicTrack track)
        {
            track.Artist = "Fred Bloggs";
        }
        static void Main(string[] args)
        {
            //Create a new music track instance
            MusicTrack track = new MusicTrack(artist: "Rob Miles", title: "My Way", length: 120);

            //Use Copy Constructor to send a copy of the track to be printed
            //Changes made by the PrintTrack method will have no effect on the original

            PrintTrack(new MusicTrack(track));
            Console.WriteLine(track.Artist);
            Console.ReadKey();
        }
    }
}
