using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._23_Parameterised_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            string SqlCommandsText = "UPDATE MusicTrack SET Artist=@artist WHERE Title=@searchTitle";

            SqlCommand command = new SqlCommand(SqlCommandsText, connection);
            command.Parameters.AddWithValue("@artist", newArtist);
            command.Parameters.AddWithValue("@SsearchTitle", searchTitle);
        }
    }
}
