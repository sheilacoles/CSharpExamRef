using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_If_Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            if (true)
                Console.WriteLine("This statement is always performed");
            else
                Console.WriteLine("This statement is never performed");
            
            //The else element of and if construction is optional
            if (true)
            {
                Console.WriteLine("This statement is always performed");
                if (true)
                {
                    Console.WriteLine("This statement is always performed");
                }
                else
                {
                    Console.WriteLine("This statement is never performed");
                }
            }

        
        }
    }
}
