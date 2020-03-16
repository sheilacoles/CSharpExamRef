using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._38_LINQ_Aggregate
{
    public class Artist
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
    public class MusicTrack
    {
        public Artist Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public int ID { get; set; }

    }
    public class TrackDetails
    {
        public string ArtistName;
        public string Title;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] artistNames = new string[] { "Rob Miles", "Freed Bloggs",
                "The Bloggs Sisters", "Immy Brown" };
            string[] titleNames = new string[] { "My Way", "Your Way", "His Way", "Her Way",
                "Milky Way" };
            int[] artistID = new int[] { 1, 2, 3, 4 };


            List<Artist> artists = new List<Artist>();
            List<MusicTrack> musicTracks = new List<MusicTrack>();

            Random rand = new Random(1);
            var artistCount = 1;
            var trackCount = 1;

            foreach (string artistName in artistNames)
            {
                Artist newArtist = new Artist { Name = artistName, ID = artistCount++ };
                artists.Add(newArtist);
                foreach (string titleName in titleNames)
                {
                    MusicTrack newTrack = new MusicTrack
                    {
                        Artist = newArtist,
                        Title = titleName,
                        Length = rand.Next(20, 600),
                        ID = trackCount++
                    };
                    musicTracks.Add(newTrack);
                }
            }
            //LINQ Aggregate
            var artistSummary = from track in musicTracks
                                join artist in artists on track.Artist.ID equals artist.ID
                                group track by artist.Name
                                into artistTrackSummary
                                select new
                                {
                                    ID = artistTrackSummary.Key,
                                    Length = artistTrackSummary.Sum(x => x.Length)
                                };

            foreach (var item in artistSummary)
            {
                Console.WriteLine("ID: {0} Length:{1}", item.ID, item.Length);
            }
            Console.ReadKey();
        }
    }
}
