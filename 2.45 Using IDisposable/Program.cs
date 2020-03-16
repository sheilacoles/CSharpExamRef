using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._45_Using_IDisposable
{
    class CrucialConnection: IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose Called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using(CrucialConnection c=new CrucialConnection())
            {
                //do something with the crucial connection
            }
            Console.ReadKey();
        }
    }
}
