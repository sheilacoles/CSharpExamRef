using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Creating_An_Enum
{
    enum AlienState
    {
        Sleeping,
        Attacking,
        Destroyed
    };
    class Program
    {
        static void Main(string[] args)
        {
            AlienState x = AlienState.Attacking;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
