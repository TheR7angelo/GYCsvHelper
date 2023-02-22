using System.Globalization;
using System.Text;
using CsvHelper.Configuration;

namespace Libs.ExportGlobal.CsvReader;

public static class Common
{
    public static CsvConfiguration GetConfigurationReader => new(CultureInfo.InvariantCulture)
        { Delimiter = ";", Encoding = Encoding.Latin1, BadDataFound = null };

    public static CsvConfiguration GetConfigurationWriter => new(CultureInfo.InvariantCulture)
        { Delimiter = ";", Encoding = Encoding.Latin1, BadDataFound = null, HasHeaderRecord = false };

    public static string GetSavePath(this SStruc.SFilePath filePath, string baseName)
    {
        var date = DateTime.Now;

        return Path.Join(filePath.FilePath, $"{baseName}{date:yyyy-MM-dd}{filePath.FileExtension}");
    }
}