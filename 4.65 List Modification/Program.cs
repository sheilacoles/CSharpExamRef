using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._65_List_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("add to end of list");     //add to end of list
            list.Insert(0, "insert at start");  //insert to start of list
            list.Insert(1, "inset new item 1"); //insert at position
            list.InsertRange(2, new string[] { "Rob", "Immy" }); //insert a range
            list.Remove("Rob");                 //remove first occurence of Rob
            list.RemoveAt(0);                   //remove element at start
            list.RemoveRange(1, 2);             //remove two elements
            list.Clear();                       //clears entire list

        }
    }
}
