using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._55_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array on integers
            int[] intArray = new int[5];

            intArray[0] = 99; //put 99 in first element
            intArray[4] = 100; //put 100 in last element

            //Use an index to work through the array
            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);

            //Use foreach to work through the array
            foreach (int intValue in intArray)
                Console.WriteLine(intValue);

            //Initialise a new array
            intArray = new int[] { 1, 2, 3, 4 };

            //Use foreach to work through the array
            foreach (int intValue in intArray)
                Console.WriteLine(intValue);

            //Multidimentional Array
            string[,] compass = new string[3, 3]
            {
                {"NW","N","NE" },
                { "W","C","E"},
                { "SW","S","SE"}
            };
            Console.WriteLine(compass[0, 0]);   //prints NW
            Console.WriteLine(compass[2, 2]);   //prints SE

            //Jagged Array - 2d array in which each rows are a different length
            int[][]jaggedArray=new int[][]
            {
                new int[] {1,2,3,4},
                new int[] {5,6,7},
                new int[] {11,12}
            };

            Console.ReadKey();
        }
    }
}
