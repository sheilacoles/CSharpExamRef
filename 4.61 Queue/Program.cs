using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._61_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> demoQueue = new Queue<string>();

            demoQueue.Enqueue("Rob Miles");
            demoQueue.Enqueue("Immy Brown");

            Console.WriteLine(demoQueue.Dequeue());
            Console.WriteLine(demoQueue.Dequeue());

            Console.ReadKey();
        }
    }
}
