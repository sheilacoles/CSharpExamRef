﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4._45_Create_XML_With_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement MusicTracks = new XElement("MusicTracks", new List<XElement>
            {
                new XElement("MusicTrack", new XElement ("Artist","Rob Miles"),
                new XElement("Title", "My Way")),
                new XElement("MusicTrack", new XElement ("Artist","Immy Brown"),
                new XElement("Title", "Her Way")),
            }
            );
        }
    }
}
