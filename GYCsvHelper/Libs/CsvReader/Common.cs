using System.Globalization;
using System.Text;
using CsvHelper.Configuration;

namespace Libs.CsvReader;

public static class Common
{ 
    public static CsvConfiguration GetConfigurationReader => new (CultureInfo.InvariantCulture)
    { Delimiter = ";", Encoding = Encoding.Latin1, BadDataFound = null };
    
    public static CsvConfiguration GetConfigurationWriter => new (CultureInfo.InvariantCulture)
        { Delimiter = ";", Encoding = Encoding.Latin1, BadDataFound = null, HasHeaderRecord = false};
}