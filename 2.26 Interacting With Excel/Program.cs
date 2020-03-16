using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._26_Interacting_With_Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the interop
            var excelApp = new Microsoft.Office.Interop.Excel.Application();

            //make the app visible
            excelApp.Visible = true;

            //add a new workbook
            excelApp.Workbooks.Add();

            //obtain the active sheet from the app
            //there is no need to cast this dynamic type
            Microsoft.Office.Interop.Excel.Worksheet workSheet = excelApp.ActiveSheet;

            //write into two cells
            workSheet.Cells[1, "A"] = "Hello";
            workSheet.Cells[1, "B"] = "from C#";
        }
    }
}
