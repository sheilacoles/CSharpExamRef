using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._51_Read_Attribute
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

    class Program
    {
        static void Main(string[] args)
        {
            Attribute a = Attribute.GetCustomAttribute(typeof(Person),
                typeof(ProgrammerAttribute));

            ProgrammerAttribute p = (ProgrammerAttribute)a;

            Console.WriteLine("Programmer: {0}", p.Programmer);
            Console.ReadKey();
        }
    }
}
