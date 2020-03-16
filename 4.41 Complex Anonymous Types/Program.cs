using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._41_Complex_Anonymous_Types
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

            //Complex Anonymous Types
            var artistSummary = MusicTracks.Join(
                                    Artists,
                                    track => track.Artist.ID,
                                    artist => artist.ID,
                                    (track, artist)=>
                                        new
                                        {
                                            track = track,
                                            artist = artist
                                        }
                                )
                                .GroupBy(
                                    temp0 => temp0.artist.Name,
                                    temp0 => temp0.track
                                )
                                .Select(
                                    artistTrackSummary => 
                                        new
                                        {
                                            ID = artistTrackSummary.Key,
                                            Length = artistTrackSummary.Sum(x => x.Length)
                                        }
                                );

        }
    }
}
