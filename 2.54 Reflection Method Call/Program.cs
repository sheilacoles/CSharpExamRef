using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2._54_Reflection_Method_Call
{
    class Person
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Type type;

            Person p = new Person();
            type = p.GetType();

            MethodInfo setMethod = type.GetMethod("set_Name");
            setMethod.Invoke(p, new object[] { "Fred" });

            Console.WriteLine(p.Name);
            Console.ReadKey();
        }
    }
}
