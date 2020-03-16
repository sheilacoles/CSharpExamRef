using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._33_IPrintable_Interface
{
    interface IPrintable
    {
        string GetPrintableText(int pageWidth, int pageHeight);
        string GetTitle();
    }
    class Report: IPrintable
    {
        public string GetPrintableText(int pageWidth, int pageHeight)
        {
            return "Report text";
        }
        public string GetTitle()
        {
            return "Report title";
        }
    }
    class ConsolePrinter
    {
        public void PrintItem(IPrintable item)
        {
            Console.WriteLine(item.GetTitle());
            Console.WriteLine(item.GetPrintableText(pageWidth: 80, pageHeight: 25));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
