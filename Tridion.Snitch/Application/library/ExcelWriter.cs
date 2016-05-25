using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelLibrary.SpreadSheet;
using NetOffice.ExcelApi.Enums;
using Excel = NetOffice.ExcelApi;
using Tridion.Snitch.Application.Contracts;

namespace Tridion.Snitch.Application.library
{
    public class ExcelWriter: IFileWriter
    {

        public string GetName()
        {
            return "Marlowe";
        }

        public string GetAction()
        {
            return "SavedCompentemplate with name Article";
        }

        public void WriteAction(User user)
        {

            var excelApplication = new Excel.Application();
            excelApplication.DisplayAlerts = false;
           

            var workbook = excelApplication.Workbooks.Open("TridionSnitch");
            var sheet = GetOrCreateUserSheet(workbook, user);
            AddExcelHeadingText(sheet);
            AddAction(sheet, user);
            sheet.SaveAs("TridionSnitch");
           
           
            //sheet.SaveAs("lekkerW");
            
           
           // 
           // excelApplication.Save("marloweTest");


          excelApplication.Quit();
            excelApplication.Dispose();
            Console.WriteLine("saved");
        }

        private Excel.Worksheet GetOrCreateUserSheet(Excel.Workbook workbooks, User user)
        {
         
            var userSheet = workbooks.Sheets.Cast<Excel.Worksheet>().FirstOrDefault(sheet => sheet.Name == user.Name);
            if (userSheet == null)
                userSheet = CreateNewSheet(workbooks, user.Name);

            return userSheet;
        }

        private void AddAction(Excel.Worksheet sheet, User user)
        {
            
          //get empty row
            var emptyRow = sheet.UsedRange;

            var col = sheet.Columns[1].Rows.Last();



        }

        private Excel.Worksheet CreateNewSheet(Excel.Workbook workbook, string name)
        {
            var userSheet = (Excel.Worksheet)workbook.Worksheets.Add();

            userSheet.Name = name;

            return userSheet;
        }

        private static void SaveAction(User user)
        {

          
        }

        private static void AddExcelHeadingText(Excel.Worksheet sheet)
        {  
            //Apply styling to heading text
            sheet.Columns[1].Cells[1,1].Value = "Name";
            sheet.Columns[2].Cells[1, 1].Value = "Type";
            sheet.Columns[3].Cells[1, 1].Value = "Path";
            sheet.Columns[4].ColumnWidth = 30;
            sheet.Columns[6].Cells[1, 1].Value = "Date";
            sheet.Cells[3, 1].ColumnWidth = 20;
            sheet.Cells.Font.Size = 14;

        }
    }
}
