using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._37_Simple_TraceSource
{
    class Program
    {
        static void Main(string[] args)
        {
            TraceSource trace = new TraceSource("Tracer", SourceLevels.All);

            trace.TraceEvent(TraceEventType.Start, 10000);
            trace.TraceEvent(TraceEventType.Warning, 10001);
            trace.TraceEvent(TraceEventType.Verbose, 10002, "At the end of the program");
            trace.TraceData(TraceEventType.Information, 10003, new object[] 
            { "Note 1", "Message 2" });

            trace.Flush();
            trace.Close();

        }
    }
}
