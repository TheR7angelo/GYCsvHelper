using Libs.PlaningAChaud.Sql.Struc;
using OfficeOpenXml;

namespace Libs.PlaningAChaud.Excel;

public class ExcelHandler
{
    private ExcelPackage Workbook;
    public ExcelHandler()
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        var path = Path.GetFullPath("GYCsvHelper/Libs/PlaningAChaud/Excel/PLANNING VQSE A CHAUD DOSO Z2.xlsx");
        Workbook = new ExcelPackage(path);
    }

    public void WriteRows(IEnumerable<VProdData> rows)
    {
        const int rowStart = 2;
        
        var rowsGroupBy = rows.GroupBy(s => s.Onglet);

        foreach (var rowKey in rowsGroupBy)
        {
            var worksheet = GetWorksheet(rowKey.Key);
            
            foreach (var row in rowKey.Select((value, index) => new { index, value }))
            {
                worksheet.Cells[rowStart + row.index, 1].Value = row.value.TypeInter;
                worksheet.Cells[rowStart + row.index, 2].Value = row.value.Nd;
                worksheet.Cells[rowStart + row.index, 3].Value = row.value.PlanifFt;
                worksheet.Cells[rowStart + row.index, 4].Value = row.value.Ui;
                worksheet.Cells[rowStart + row.index, 5].Value = row.value.ActProd;
                worksheet.Cells[rowStart + row.index, 6].Value = row.value.Client;
                worksheet.Cells[rowStart + row.index, 7].Value = row.value.Adresse;
                worksheet.Cells[rowStart + row.index, 8].Value = row.value.PostalCode;
                worksheet.Cells[rowStart + row.index, 9].Value = row.value.VilleSite;
                worksheet.Cells[rowStart + row.index, 10].Value = row.value.Contact;
                worksheet.Cells[rowStart + row.index, 11].Value = row.value.EscaladeN1;
            }
        }
    }

    private ExcelWorksheet GetWorksheet(string sheetName) 
        => Workbook.Workbook.Worksheets[sheetName];

    public void Save()
    {
        Workbook.SaveAs("test.xlsx");
    }
}