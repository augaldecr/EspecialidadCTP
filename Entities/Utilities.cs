using ClosedXML.Excel;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Entities
{
    public static class Utilities
    {
        public static void ExportDataSet(string destino, DataTable table, string name)
        {
            try
            {
                XLWorkbook wb = new XLWorkbook();
                wb.Worksheets.Add(table, name);
                wb.SaveAs(destino);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
