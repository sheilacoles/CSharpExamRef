using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._31_Line_Numbers
{
    class Program
    {
        static void Exploder ()
        {
#line 1 "kapow.ninja"
            throw new Exception("Bang");
#line default
        }

        static void Main(string[] args)
        {
            try
            {
                Exploder();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
