using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _3._03_Validating_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string invalidJson = 
                "{\"Artist\":\"Rob Miles\",\"Title\":\"My Way\",\"Length\":150\"}";

            try
            {
                MusicTrack trackRead = JsonConvert.DeserializeObject<MusicTrack>
                    (invalidJson);
                Console.Write("Read back: ");
                Console.WriteLine(trackRead);
            }
            catch (JsonReaderException e) { Console.WriteLine(e.Message); }
            Console.ReadKey();           
        }
    }
}
