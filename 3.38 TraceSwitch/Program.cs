using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._38_TraceSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            TraceSwitch control = new TraceSwitch("Control", "Control the trace output");
            control.Level = TraceLevel.Warning;

            if (control.TraceError)
                Console.WriteLine("An error has occured");

            Trace.WriteLineIf(control.TraceWarning, "A warning message");
        }
    }
}
