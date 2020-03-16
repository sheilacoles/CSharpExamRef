using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._69_ICollection_Interface
{
    class CompassCollection : ICollection
    {
        //Array containing values in this collection
        string[] compassPonts = { "North", "South", "East", "West" };

        //count property to return the length of the collection
        public int Count
        {
            get { return compassPonts.Length; }
        }

        //Returns an object that can be used to synchronise
        //access to this object
        public object SyncRoot
        {
            get { return this; }
        }
        //Returns true if the collection is thread safe
        //this collection is not
        public bool IsSynchronized
        {
            get { return false; }
        }

        //Provide a copyto behaviour
        public void CopyTo(Array array, int index)
        {
            foreach(string point in compassPonts)
            {
                array.SetValue(point, index);
                index = index + 1;
            }
        }

        //Required for IEnumerate
        //Returns the enumerator from the embedded array
        public IEnumerator GetEnumerator()
        {
            return compassPonts.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
