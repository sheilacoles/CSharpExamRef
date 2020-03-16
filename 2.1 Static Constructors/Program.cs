using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Static_Constructors
{
    class Alien
    {
        //Alien Code here
        static Alien()
        {
            Console.WriteLine("Static Alien constructor running");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
