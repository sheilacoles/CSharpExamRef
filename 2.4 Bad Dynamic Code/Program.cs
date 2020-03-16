using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._24_Bad_Dynamic_Code
{
    class MessageDisplay
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MessageDisplay m = new MessageDisplay();
            m.DisplayMessage("Hello World");

            dynamic d = new MessageDisplay();
            d.Banana("helloo world");
        }
    }
}
