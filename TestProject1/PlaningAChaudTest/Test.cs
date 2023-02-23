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

        sqlHandler.ImportRows(rowsCsv);
        var rowsSql = sqlHandler.GetRows();

        var excelHandler = new ExcelHandler();
        excelHandler.WriteRows(rowsSql);
        
        excelHandler.Save();
    }
}