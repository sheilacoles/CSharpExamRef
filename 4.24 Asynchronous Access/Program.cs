using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._24_Asynchronous_Access
{
    class Program
    {
        static void Main(string[] args)
        {
            async Task<string> dumpDatabase(SqlConnection connection)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM MusicTracl", connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();
                StringBuilder databaseList = new StringBuilder();
                while (await reader.ReadAsync())
                {
                    string id = reader["ID"].ToString();
                    string artist = reader["Artist"].ToString();
                    string title = reader["Title"].ToString();

                    string row = String.Format("ID: {0} Artist: {1} Title: {2}", id, artist, title);
                    databaseList.AppendLine(row);
                }
                return databaseList.ToString();
            }
        }
    }
}
