using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._46_Bind_To_Event_Log
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoryName = "Image Processing";

            EventLog imageEventLog = new EventLog();
            imageEventLog.Source = categoryName;
            imageEventLog.EntryWritten += ImageEventLog_EntryWritten;
            imageEventLog.EnableRaisingEvents = true;

            Console.WriteLine("Listening for log events");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        private static void ImageEventLog_EntryWritten(object sender, EntryWrittenEventArgs e)
        {
            Console.WriteLine(e.Entry.Message);
        }
    }
}
