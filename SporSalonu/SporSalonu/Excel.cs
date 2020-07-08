using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace SporSalonu
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook workbook;
        Worksheet worksheet;
        public Excel(string path, int sheet)
        {
            this.path = path;
            workbook = excel.Workbooks.Open(path);
            worksheet = excel.Worksheets[sheet];
        }

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (worksheet.Cells[i, j].Value2 != null)
                return worksheet.Cells[i, j].Value2;
            else
                return "";
        }
        public void WriteCell(int i, int j, string s)
        {
            i++;
            j++;
            worksheet.Cells[i, j].Value2 = s;
        }
        public void Save()
        {
            workbook.Save();
        }
        public void Close()
        {
            workbook.Close();
        }
    }
}
