using FishConsole.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var service = new FishServiceClient())
            {
                var fishes = service.GetFishes();
                foreach (var fish in fishes)
                {
                    Console.WriteLine(fish.Name);

                }
                Console.ReadKey();
            }
        }
    }
}
