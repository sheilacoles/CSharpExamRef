using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._68_Custom_Collection
{
    class TrackStore : List<MusicTrack>
    {
        public int RemoveArtist(string removeName)
        {
            List<MusicTrack> removeList = new List<MusicTrack>();
            foreach (MusicTrack track in this)
                if (track.Artist == removeName)
                    removeList.Add(track);

            foreach (MusicTrack track in removeList)
                this.Remove(track);

            return removeList.Count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
