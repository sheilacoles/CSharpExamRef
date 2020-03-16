using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._57_ToUpper
{
    public class Person
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[] {
                new Person { Name = "john" },
                new Person { Name = "mary" },
                new Person { Name = "bob" }
            };     

            //In a list of references to objects, the objects can be changed
            foreach (Person person in people)
            {
                person.Name = person.Name.ToUpper();
                Console.WriteLine(person.Name);
            }

            Console.ReadKey();
        }
    }
}
