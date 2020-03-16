using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._36_Trace_Listener
{
    class Program
    {
        static void Main(string[] args)
        {
            TraceListener consoleListener = new ConsoleTraceListener();

            Trace.Listeners.Add(consoleListener);
            Trace.TraceInformation("This is an information message");
            Trace.TraceWarning("This is a warning message");
            Trace.TraceError("This is an error message");

            Console.ReadKey();
        }
    }
}
