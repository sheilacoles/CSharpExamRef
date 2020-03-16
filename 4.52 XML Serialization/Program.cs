using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _4._52_XML_Serialization
{
    [Serializable]
    class Artist
    {
        public string Name { get; set; }
        [NonSerialized]
        int tempData;
    }
    [Serializable]
    class MusicTrack
    {
        public Artist Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
    }
    [Serializable]
    class MusicDataStore
    {
        List<Artist> Artists = new List<Artist>();
        List<MusicTrack> MusicTracks = new List<MusicTrack>();

        public static MusicDataStore TestData()
        {
            MusicDataStore result = new MusicDataStore();
            //create same test date set as used for LINQ example
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MusicDataStore musicData = MusicDataStore.TestData();

            XmlSerializer formatter = new XmlSerializer(typeof(MusicDataStore));

            using (FileStream outputStream =
                new FileStream ("MusicTracks.xml",FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(outputStream, musicData);
            }

            MusicDataStore inputData;

            using (FileStream inputStream =
                new FileStream("MusicTracks.xml", FileMode.Open, FileAccess.Read))
            {
                inputData = (MusicDataStore)formatter.Deserialize(inputStream);
            }
        }
    }
}
