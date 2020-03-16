using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._52_GetType_Method
{
    class Program
    {
        [AttributeUsage(AttributeTargets.Class)]
        class ProgrammerAttribute : Attribute
        {
            private string _programmerValue;

            public ProgrammerAttribute(string programmer)
            {
                _programmerValue = programmer;
            }
            public string Programmer
            {
                get
                {
                    return _programmerValue;
                }
            }
        }
        [ProgrammerAttribute(programmer: "Fred")]
        class Person
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            System.Type type;

            Person p = new Person();
            type = p.GetType();
            Console.WriteLine("Person type: {0}", type.ToString());
            Console.ReadKey();
        }
    }
}
