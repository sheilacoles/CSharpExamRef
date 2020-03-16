﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._78_Exception_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer: ");
                string numberText = Console.ReadLine();
                int result;
                result = int.Parse(numberText);
                Console.WriteLine("You entered {0}", result);
                int sum = 1 / result;
                Console.WriteLine("Sum is {0}", sum);
            }
            catch(NotFiniteNumberException nx)
            {
                Console.WriteLine("Invalid number");
            }
            catch(DivideByZeroException zx)
            {
                Console.WriteLine("Divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception");
            }
            Console.ReadKey();
        }
    }
}
