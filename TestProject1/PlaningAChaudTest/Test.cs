using System.Globalization;
using LibsPlaningAChaud.CsvReader;
using LibsPlaningAChaud.Excel;
using LibsPlaningAChaud.Sql;

namespace TestProject1.PlaningAChaudTest;

public class Test
{
    [Fact]
    private void TestRead()
    {
        var db = Path.GetFullPath("Sql/data.sqlite");
        
        const string file = "C:\\Users\\ZP6177\\Downloads\\Nouveau dossier\\export_interventions.csv";
        const EActivite activity = EActivite.ProdGpCu;

        var sqlHandler = new SqlHandler(db);
        var rowsCsv = Reader.Read(file, activity);

        sqlHandler.ImportRows(rowsCsv, activity);
        var rowsSql = sqlHandler.GetRows();

        var excelHandler = new ExcelHandler();
        excelHandler.WriteRows(rowsSql);

        var myCi = new CultureInfo("fr-FR");
        var myCal = myCi.Calendar;
        var myCwr = myCi.DateTimeFormat.CalendarWeekRule;
        var myFirstDow = myCi.DateTimeFormat.FirstDayOfWeek;

        var d = myCal.GetWeekOfYear(DateTime.Now, myCwr, myFirstDow);
        var defaultName = $"PLANNING VQSE A CHAUD DOSO Z2 S{d}";
        
        excelHandler.Save($"{defaultName}.xlsx");
    }
}