using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._45_Read_From_Event_Log
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoryName = "Image Processing";

            if (!EventLog.SourceExists(categoryName))
                Console.WriteLine("Event log not present");
            else
            {
                EventLog imageEventLog = new EventLog();
                imageEventLog.Source = categoryName;
                foreach (EventLogEntry entry in imageEventLog.Entries)
                {
                    Console.WriteLine("Source: {0} Type: {1} Time: {2} Message: {3}",
                        entry.Source, entry.EntryType, entry.TimeWritten,entry.Message);
                }
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
