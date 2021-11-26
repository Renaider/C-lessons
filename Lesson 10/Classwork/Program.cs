using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] diseases = new string[10, 2];
            Excel excel = new Excel("C:\\Users\\Kpaq\\Downloads\\1. Болезни.xlsx", 1);
            Console.WriteLine(excel.ReadCell(0, 0));
            for (int i = 0; i < 10; i++)
            {
                diseases[i, 0] += excel.ReadCell(i+1, 1);
                diseases[i, 1] += excel.ReadCell(i+1, 2);
            }
            foreach (string data in diseases)
            {
                Console.WriteLine(data);
            }
        }
    }
}