using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._34_Trace_Code_Tracing
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.WriteLine("Starting the program");
            Trace.TraceInformation("This is an information message");
            Trace.TraceWarning("This is a warning message");
            Trace.TraceError("This is an error message");
        }
    }
}
