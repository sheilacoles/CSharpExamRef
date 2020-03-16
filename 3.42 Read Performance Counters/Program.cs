using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace _3._42_Read_Performance_Counters
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformanceCounter processor = new PerformanceCounter(
                categoryName:"Processor Information",
                counterName:"% Processor Time",
                instanceName:"_Total");
            Console.WriteLine("Press any key to stop");

            while (true)
            {
                Console.WriteLine("Processor time: {0}", processor.NextValue());
                Thread.Sleep(500);
                if (Console.KeyAvailable)
                    break;
            }
        }
    }
}
