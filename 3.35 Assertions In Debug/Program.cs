using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3._35_Assertions_In_Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerName = "Rob";
            Debug.Assert(!string.IsNullOrWhiteSpace(customerName));

            customerName = " ";
            Debug.Assert(!string.IsNullOrWhiteSpace(customerName));
        }
    }
}
