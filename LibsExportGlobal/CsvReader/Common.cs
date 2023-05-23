using System.Globalization;
using System.Text;
using CsvHelper.Configuration;
using LibsExportGlobal.ExportGlobal.SStruc;

namespace LibsExportGlobal.CsvReader;

public static class Common
{
    public static CsvConfiguration GetConfigurationReader => new(CultureInfo.InvariantCulture)
        { Delimiter = ";", Encoding = Encoding.Latin1, BadDataFound = null };

    public static CsvConfiguration GetConfigurationWriter => new(CultureInfo.InvariantCulture)
        { Delimiter = ";", Encoding = Encoding.Latin1, BadDataFound = null, HasHeaderRecord = true };

    public static string GetSavePath(this SFilePath filePath, string baseName)
    {
        var date = DateTime.Now;

        return Path.Join(filePath.FilePath, $"{baseName}{date:yyyy-MM-dd}{filePath.FileExtension}");
    }
}