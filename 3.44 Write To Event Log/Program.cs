using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._44_Write_To_Event_Log
{
    static EventLog imageEventLog;

    enum CreationResult
    {
        CreatedLog,
        LoadedLog
    };

    static CreationResult SetupLog()
    {
        string categoryName = "Image Processing";

        if (EventLog.SourceExists(categoryName))
        {
            imageEventLog = new EventLog();
            imageEventLog.Source = categoryName;
            return CreationResult.LoadedLog;
        }
        EventLog.CreateEventSource(source:categoryName,
            logName:categoryName+ " log");

        return CreationResult.CreatedLog;
    }

    class Program
    {
        static void Main(string[] args)
        {
            if(SetupLog() == CreationResult.CreatedLog)
            {
                Console.WriteLine("Log Created");
                Console.WriteLine("Restart program");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Processing started");

            imageEventLog.WriteEntry("Image processing started");

            //process images

            imageEventLog.WriteEntry("Image processing ended");

            Console.WriteLine("Processing complete. Press any key to exit");
            Console.ReadKey();
        }
    }
}
