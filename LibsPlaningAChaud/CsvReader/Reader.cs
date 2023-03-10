using System.Text;

namespace LibsPlaningAChaud.CsvReader;

public static class Reader
{
    public static IEnumerable<ExportInterventionCsv> Read(string filePath, EActivity activity)
    {
        using var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        using var reader = new StreamReader(fileStream, Encoding.Latin1);
        var csv = new CsvHelper.CsvReader(reader, Common.GetConfigurationReader);

        var records = csv.GetRecords<ExportInterventionCsv>().ToList();

        var reads = new List<ExportInterventionCsv>();
        foreach (var record in records)
        {
            record.Activity = (int)activity;
            reads.Add(record);
        }

        return reads;
    }
}