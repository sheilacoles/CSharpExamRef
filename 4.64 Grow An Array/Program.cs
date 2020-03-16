using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._64_Grow_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //array class does not provide methods to add or remove elements 
            //need to create new array and CopyTo new array

            int[] dataArray = { 1, 2, 3, 4 };
            int[] tempArray = new int[5];
            dataArray.CopyTo(tempArray, 0);
            dataArray = tempArray;
        }
    }
}
