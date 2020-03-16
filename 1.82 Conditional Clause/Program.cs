using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._82_Conditional_Clause
{
    class CalcException : Exception
    {
        public enum CalcErrorCodes
        {
            InvalidNumberText,
            DivideByZero
        }
        public CalcErrorCodes Error { get; set; }
        public CalcException(string message, CalcErrorCodes error) : base(message)
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
                throw new CalcException("Calc Failed", CalcException.CalcErrorCodes.DivideByZero);
            }
            catch(CalcException ce) when (ce.Error == CalcException.CalcErrorCodes.DivideByZero)
            {
                Console.WriteLine("Divide by zero error");
            }
        }
    }
}
