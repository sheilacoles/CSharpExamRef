using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._66_Dictionary_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Rob Miles"); //add an entry
            dictionary.Remove(1);           //remove the entry with given key
        }
    }
}
