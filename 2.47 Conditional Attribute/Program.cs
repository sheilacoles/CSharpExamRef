//#define TERSE
#define VERBOSE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2._47_Conditional_Attribute
{
    class Program
    {
        [Conditional("VERBOSE"), Conditional("TERSE")]
        static void ReportHeader()
        {
            Console.WriteLine("This is the header for the report");
        }
        [Conditional("VERBOSE")]
        static void VerboseReport()
        {
            Console.WriteLine("This is the output from the verbose report");
        }
        [Conditional("TERSE")]
        static void TerseReport()
        {
            Console.WriteLine("This is the output from the terse report");
        }
        static void Main(string[] args)
        {
            ReportHeader();
            TerseReport();
            VerboseReport();
            Console.ReadKey();          
        }
    }
}
