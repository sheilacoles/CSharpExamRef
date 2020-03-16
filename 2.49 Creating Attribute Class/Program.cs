using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._49_Creating_Attribute_Class
{
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
    [ProgrammerAttribute(programmer:"Fred")]
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
