using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._21_Update_With_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                dumpDatabase(connection);
                SqlCommand command = new SqlCommand(
                    "UPDATE MusicTrack SET Artist='Robert Miles' WHERE ID='1'", 
                    connection);
                int result = command.ExecuteNonQuery();
                Console.WriteLine("Number of entries updated: {0}", result);
                dumpDatabase(connection);
            }
        }
    }
}
