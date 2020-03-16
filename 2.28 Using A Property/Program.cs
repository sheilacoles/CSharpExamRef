using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._28_Using_A_Property
{
    class Customer
    {
        private string _nameValue;

        public string Name
        {
            get { return _nameValue; }
            set
            {
                if (value == "")
                    throw new Exception("Invalid customer name");
                _nameValue = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Name = "Rob";
            Console.WriteLine("Customer name: {0}", c.Name);

            c.Name = "";
            Console.WriteLine("Customer name: {0}", c.Name);

            Console.ReadKey();
        }
    }
}
