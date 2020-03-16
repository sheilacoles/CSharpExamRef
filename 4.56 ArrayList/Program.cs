using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._56_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);

            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine(arrayList[i]);

            //possible to put any type of object into the same ArrayList
            //Non-typed Collections
            ArrayList messyList = new ArrayList();
            messyList.Add(1);   //add an integer to the list
            messyList.Add("Rob Miles"); //add a string to the list
            messyList.Add(new ArrayList()); //add an ArrayList to the list

            //all references in the list are references to objects - requires to be cast
            int messyInt = (int)messyList[0];
        }
    }
}
