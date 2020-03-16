using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _4._15_WebClient_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            async Task<string> readWebpage(string uri)
            {
                WebClient client = new WebClient();
                return await client.DownloadStringTaskAsync(uri);
            }
        }
    }
}
