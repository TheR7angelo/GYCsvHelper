using System.Globalization;
using System.Text;
using CsvHelper.Configuration;

namespace LibsPlaningAChaud.CsvReader;

public static class Common
{
    public static CsvConfiguration GetConfigurationReader => new(CultureInfo.InvariantCulture)
        { Delimiter = ";", Encoding = Encoding.Latin1, BadDataFound = null };
}