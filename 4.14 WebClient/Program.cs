using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _4._14_WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string siteText = client.DownloadString("http://www.microsoft.com");
            Console.WriteLine(siteText);
        }
    }
}
