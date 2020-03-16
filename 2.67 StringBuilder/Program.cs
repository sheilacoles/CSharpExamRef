using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._67_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Rob";
            string secondName = "Miles";
            
            //string fullName = firstName + " " + secondName;

            StringBuilder fullNameBuilder = new StringBuilder();
            fullNameBuilder.Append(firstName);
            fullNameBuilder.Append(" ");
            fullNameBuilder.Append(secondName);
            Console.WriteLine(fullNameBuilder.ToString());
        }
    }
}
