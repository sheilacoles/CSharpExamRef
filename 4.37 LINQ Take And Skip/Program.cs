using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._37_LINQ_Take_And_Skip
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

            //LINQ take and snip
            int pageNo = 0;
            int pageSize = 10;
            while (true)
            {
                //Get track info
                var trackList = from musicTrack in musicTracks.Skip(pageNo * pageSize).Take(pageSize)
                                join artist in artists on musicTrack.Artist.ID equals artist.ID
                                select new
                                {
                                    ArtistName = artist.Name,
                                    musicTrack.Title
                                };
                //Quit if we reach end of data
                if (trackList.Count() == 0)
                    break;

                //Display query result
                foreach (var item in trackList)
                    Console.WriteLine("Artist:{0} Title:{1}",
                        item.ArtistName, item.Title);
                Console.Write("Press any key to continue");
                Console.ReadKey();

                //Move onto next page
                pageNo++;
                Console.ReadKey();
            }
        }
    }
}
