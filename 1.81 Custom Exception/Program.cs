using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._81_Custom_Exception
{
    class CalcException : Exception
    {
        public enum CalcErrorCodes
        {
            InvalidNumberText,
            DivideByZero
        }
        public CalcErrorCodes Error { get; set; }
        public CalcException(string message, CalcErrorCodes error): base(message)
        {
            Error = error;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CalcException("Calc Failed",
                    CalcException.CalcErrorCodes.InvalidNumberText);
            }
            catch(CalcException ce)
            {
                Console.WriteLine("Error: {0}", ce.Error);
            }
            Console.ReadKey();
        }
    }
}
