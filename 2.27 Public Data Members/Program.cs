using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._27_Public_Data_Members
{
    class Customer
    {
        public string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Name = "Rob";
            Console.WriteLine("Customer name: {0}", c.Name);
            Console.ReadKey();
        }
    }
}
