using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._67_Set_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Rob Miles");   //add an item
            set.Remove("Rob Miles");//remove an item
            set.RemoveWhere(x => x.StartsWith("R")); //removes all items starting with R


        }
    }
}
