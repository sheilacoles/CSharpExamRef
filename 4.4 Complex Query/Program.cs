using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_Complex_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            //Same code as LINQ Aggregate 4.38

            /*
             SQL Query to match is as below:

            SELECT SUM ([t0].[Length], [t1].[Name] AS [ID]
            FROM [MusicTrack] AS [t0]
            INNER JOIN [Artist] AS [t1] ON [t0].[ArtistID] = [t1].[ID]
            GROUP BY [t1].[Name]
             */
        }
    }
}
