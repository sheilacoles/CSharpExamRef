using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._41_Stopwatch_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            sequencialTest();
            stopwatch.Stop();
            Console.WriteLine("Sequential time in milliseconds: {0}",
                stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();
            parallelTest();
            stopwatch.Stop();
            Console.WriteLine("Parallel loop time in milliseconds: {0}",
                stopwatch.ElapsedMilliseconds);
        }
    }
}
