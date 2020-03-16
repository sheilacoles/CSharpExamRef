using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _4._48_Binary_Serialization
{
    [Serializable]
    class Artist
    {
        public string Name { get; set; }
        public int ID { get; set; }
        [NonSerialized]
        int tempData;
    }
    [Serializable]
    class MusicTrack
    {
        public Artist Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public int ID { get; set; }
    }
    [Serializable]
    class MusicDataStore
    {
        public List<Artist> Artists = new List<Artist>();
        public List<MusicTrack> MusicTracks = new List<MusicTrack>();

        public MusicDataStore TestData()
        {
            MusicDataStore result = new MusicDataStore();
            //create same test data set as used for LINQ example

                string[] artistNames = new string[] { "Rob Miles", "Freed Bloggs",
                "The Bloggs Sisters", "Immy Brown" };
                string[] titleNames = new string[] { "My Way", "Your Way", "His Way", "Her Way",
                "Milky Way" };

                Random rand = new Random(1);
                var artistCount = 1;
                var trackCount = 1;

                foreach (string artistName in artistNames)
                {
                    Artist newArtist = new Artist { Name = artistName, ID = artistCount++ };
                    Artists.Add(newArtist);
                    foreach (string titleName in titleNames)
                    {
                        MusicTrack newTrack = new MusicTrack
                        {
                            Artist = newArtist,
                            Title = titleName,
                            Length = rand.Next(20, 600),
                            ID = trackCount++
                        };
                        MusicTracks.Add(newTrack);
                    }
                }


                return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MusicDataStore musicData = new MusicDataStore().TestData();

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream outputStream =
                new FileStream("MusicTracks.bin", FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(outputStream, musicData);
            }

            MusicDataStore inputData;

            using (FileStream inputStream =
                new FileStream("MusicTracks.bin", FileMode.Open, FileAccess.Read))
            {
                inputData = (MusicDataStore)formatter.Deserialize(inputStream);
            }

            foreach (var item in inputData.Artists)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }
    }
}
