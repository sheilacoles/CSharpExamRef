using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._43_Create_Performance_Counters
{
    class Program
    {
        static PerformanceCounter TotalImageCounter;
        static PerformanceCounter ImagesPerSecondCounter;

        enum CreationResult
        {
            CreatedCounters,
            LoadedCounters
        };

        static CreationResult SetupPerformanceCounters()
        {
            string categoryName = "Image Processing";

            if (PerformanceCounterCategory.Exists(categoryName))
            {
                //production code should use using
                TotalImageCounter = new PerformanceCounter(categoryName: categoryName,
                    counterName: "# of images processed",
                    readOnly: false);

                //production code should use using
                ImagesPerSecondCounter = new PerformanceCounter(categoryName: categoryName,
                    counterName: "# images processed per second",
                    readOnly: false);

                return CreationResult.LoadedCounters;
            }
            CounterCreationData[] counters = new CounterCreationData[] 
            {
                new CounterCreationData(counterName:"# of images processed",
                counterHelp: "number of images resized",
                counterType: PerformanceCounterType.NumberOfItems64),

                new CounterCreationData(counterName: "# images processed per second",
                counterHelp: "number of images processed per second",
                counterType: PerformanceCounterType.RateOfCountsPerSecond32)
            };
            CounterCreationDataCollection counterCollection =
                new CounterCreationDataCollection(counters);

            PerformanceCounterCategory.Create(categoryName: categoryName,
                categoryHelp:"Image processing information",
                categoryType:PerformanceCounterCategoryType.SingleInstance,
                counterData:counterCollection);

            return CreationResult.CreatedCounters;
        }

        static void Main(string[] args)
        {
            if(SetupPerformanceCounters() == CreationResult.CreatedCounters)
            {
                Console.WriteLine("Performance counters created");
                Console.WriteLine("Restart the program");
                Console.ReadKey();
                return;
            }
        }
    }
}
