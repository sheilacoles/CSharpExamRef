using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13_ASP_Validation
{
    class Program
    {
        public class MusicTrack
        {
            public int ID { get; set; }
            public string Artist { get; set; }
            public string Title { get; set; }

            [Range(20,600)]
            public int Length { get; set; }
        }
        static void Main(string[] args)
        {
        }
    }
}
