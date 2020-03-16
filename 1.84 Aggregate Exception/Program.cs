using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _1._84_Aggregate_Exception
{
    class Program
    {
        async static Task<string> FetchWebPage(string uri)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);
            return await response.Content.ReadAsStringAsync();
        }
        static void Main(string[] args)
        {
            try
            {
                Task<string> getpage = FetchWebPage("invaliod uri");
                getpage.Wait();
                Console.WriteLine(getpage.Result);
            }
            catch(AggregateException ag)
            {
                foreach(Exception e in ag.InnerExceptions)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
