using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _4._19_Read_with_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;" +
                "Database=MusicTracksContent-e0f0cd0d-38fe-44a4-add2-359310ff8b5d;" +
                "Trusted_Connection=True;MultipleActiveResultsSets=true";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM MusicTrack", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string artist = reader["Artist"].ToString();
                    string title = reader["Title"].ToString();
                    Console.WriteLine("Artist: {0}  Title: {1}", artist, title);
                }
            }
            Console.ReadKey();
        }
    }
}
