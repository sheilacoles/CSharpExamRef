using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._07_Drive_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo drive in drives)
            {
                Console.Write("Name: {0}", drive.Name);
                if (drive.IsReady)
                {
                    Console.Write(" Type:{0}", drive.DriveType);
                    Console.Write(" Format:{0}", drive.DriveFormat);
                    Console.Write(" Free Space:{0}", drive.TotalFreeSpace);
                }
                else
                {
                    Console.Write("Drive not ready");
                }
                Console.ReadKey();
            }
        }
    }
}
