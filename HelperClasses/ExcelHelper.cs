using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace HelperClasses
{
    /// <summary>
    /// Class for interacting with an Excel application
    /// </summary>
    public class ExcelHelper
    {
        /// <summary>
        /// Method to read all data from an excel file
        /// </summary>
        /// <param name="excelFileName">Excel file name</param>
        public void GetExcelData(string excelFileName)
        {
            //ExcelHelper ex= new ExcelHelper();
            // ex.GetExcelData(@"C:\Tmp\Sample.xls");
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@excelFileName);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;

            for(int row = 1; row <= rowCount; row++)
            {
                int col = 2;

                string strVal = xlRange.Cells[row, col].Value2.ToSTring();

                strVal = strVal.Trim();

                Console.WriteLine("val" + strVal);

                col++;
            }

            RunMacro(xlApp, new Object[] { "Worksheet01.xlsm!First_Macro" });

            // xlWorksheet.Cells[5, 5] = "test";

            xlWorkbook.Save();

            GC.Collect();

            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);

            Marshal.ReleaseComObject(xlWorksheet);

            // Quit and Release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);


        }

        /// <summary>
        /// Method for running a macro in an excel sheet.
        /// </summary>
        /// <param name="oApp">Excel application</param>
        /// <param name="oRunArgs">Arguments to pass to run the macro</param>
        private void RunMacro(object oApp, object[] oRunArgs)
        {
            oApp.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, oApp, oRunArgs);
        }
    }
}
