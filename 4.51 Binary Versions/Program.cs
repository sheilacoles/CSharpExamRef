using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _4._51_Binary_Versions
{
    [Serializable]
    class Artist
    {
        public string Name { get; set; }
    }
    [Serializable]
    class MusicTrack
    {
        public Artist Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }

        [OptionalField]
        public string Style;

        [OnDeserializing]
        internal void OnDeserializingMethod (StreamingContext context)
        {
            Style = "unknown";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
