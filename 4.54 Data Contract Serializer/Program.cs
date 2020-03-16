using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _4._54_Data_Contract_Serializer
{
    [DataContract]
    public class Artist
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
    [DataContract]
    public class MusicTrack
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int ArtistID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int Length { get; set; }
    }
    public class MusicDataStore
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

            DataContractSerializer formatter = new DataContractSerializer(typeof(MusicDataStore));

            using (FileStream outputStream =
                new FileStream("MusicTracks.xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.WriteObject(outputStream, musicData);
            }

            MusicDataStore inputData;

            using (FileStream inputStream =
                new FileStream("MusicTracks.xml", FileMode.Open, FileAccess.Read))
            {
                inputData = (MusicDataStore)formatter.ReadObject(inputStream);
            }

        }
    }
}
