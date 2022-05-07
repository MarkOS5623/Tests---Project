﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _excel = Microsoft.Office.Interop.Excel;

namespace Tests___Project
{
    public class Excel
    {
        string _Path = "";
        _Application _Excel = new _excel.Application();
        Workbook _Wb;
        Worksheet _Ws;
        public Excel() { }
        public Excel(String path, int sheet)
        {
            this._Path = path;
            _Wb = _Excel.Workbooks.Open(path);
            _Ws = _Wb.Worksheets[sheet];
        }

        public void CreateNewFile()
        {
            this._Wb = _Excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this._Ws = _Wb.Worksheets[1];
        }
        public void CreateNewSheet()
        {
            Worksheet tempSheet = _Wb.Worksheets.Add(After : _Ws);
  
        }
        public String ReadCell(int col, int row)
        {
            col++;
            row++;
            if (_Ws.Cells[col, row].Value2 != null) return _Ws.Cells[row, col].Value2;
            else return "";
        }
        public void WriteToCell(int col, int row, String s)
        {
            col++;
            row++;
            _Ws.Cells[row, col].Value2 = s;
        }
        public void Save()
        {
            _Wb.Save();
        }
        public void SaveAs(String path)
        {
            _Wb.SaveAs(path);
        }
        public void Close()
        {
            _Wb.Close();
        }
    }
}