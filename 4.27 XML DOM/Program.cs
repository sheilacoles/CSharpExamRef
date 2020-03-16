using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _4._27_XML_DOM
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XMLDocument);

            System.Xml.XmlElement rootElement = doc.DocumentElement;
            //make sure it is the right element
            if (rootElement.Name != "MusicTrack")
                Console.WriteLine("Not a music track");
            else
            {
                string artist = rootElement["Artist"].FirstChild.Value;
                Console.WriteLine("", artist);
                string title = rootElement["Title"].FirstChild.Value;
                Console.WriteLine("Artist:{0} Title:{1}", artist, title);
            }
        }
    }
}
