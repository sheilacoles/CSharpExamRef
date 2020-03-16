using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._22_SQL_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the title of the track to update: ");
            string searchTitle = Console.ReadLine();
            Console.Write("Enter the new artist name: ");
            string newArtist = Console.ReadLine();
            string SqlCommandText = "UPDATE MusicTrack SET Artist='" + newArtist + 
                "' WHERE Title='"+ searchTitle + "'";
        }
    }
}
