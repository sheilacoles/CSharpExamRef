using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStorage
{
    public class MusicTrack
    {
        public MusicTrack(string artist, string title, int length)
        {
            Artist = artist;
            Title = title;
            Length = length;
        }

        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
    }
}
