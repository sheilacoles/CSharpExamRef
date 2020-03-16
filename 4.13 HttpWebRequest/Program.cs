using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace _4._13_HttpWebRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest webRequest = WebRequest.Create("https://www.microsoft.com");
            WebResponse webResponse = webRequest.GetResponse();

            using (StreamReader responseReader = new StreamReader(webResponse.GetResponseStream()))
            {
                string siteText = responseReader.ReadToEnd();
                Console.WriteLine(siteText);
            }
        }
    }
}
