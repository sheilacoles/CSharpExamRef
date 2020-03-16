using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._19_Method_Overriding
{
    class Document
    {
        //All documents have the same GetDate behaviour so
        //this method will not be overridden
        public void GetDate()
        {
            Console.WriteLine("Hello from GetDate in Document");
        }
        //A document may have its own DoPrint behaviour so
        //this method is virtual so it can be overridden
        public virtual void DoPrint()
        {
            Console.WriteLine("Hello from DoPrint in Document");
        }
    }
    //The Invoice class derives from document class
    class Invoice: Document
    {
        //Override the DoPrint method in the base class
        //to provide custom printing behaviour in Invoice
        public override void DoPrint()
        {
            Console.WriteLine("Hello from DoPrint in Invoice");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create an Invoice
            Invoice c = new Invoice();
            //This will run the GetDate from Document
            c.GetDate();
            //This will run the DoPrint from Invoice
            c.DoPrint();
            Console.ReadKey();
        }
    }
}
