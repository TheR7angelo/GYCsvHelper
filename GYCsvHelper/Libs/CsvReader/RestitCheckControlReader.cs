using System.Text;
using CsvHelper;
using Libs.SStruc;

namespace Libs.CsvReader;

public class RestitCheckControlReader : IReader, IDisposable
{
    private string FilePath { get; }
    private string FileTmp { get; }
    private string FileSavePath { get; }
    
    private SFilePath FileInfo { get; }

    private const string BaseName = "Restitution_Fiches_Validees_complet_";

    public RestitCheckControlReader(string filePath)
    {
        FilePath = filePath;
        FileInfo = new SFilePath(filePath);
        
        FileSavePath = FileInfo.GetSavePath(BaseName);
        FileTmp = Path.GetTempFileName();
    }

    public void CleanFirstRow(int row, bool keepHeader)
    {
        var data = File.ReadAllLines(FilePath, Encoding.Latin1);

        var linesToWrite = new List<string>();
        if (keepHeader) linesToWrite.Add(data[0]);
        linesToWrite.AddRange(data.Skip(row));
        
        File.WriteAllLines(FileTmp, linesToWrite, Encoding.Latin1);
    }
    
    public List<T> Read<T>()
    {
        using var reader = new StreamReader(FileTmp, Encoding.Latin1);
        var csv = new CsvHelper.CsvReader(reader, Common.GetConfigurationReader);
        
        return csv.GetRecords<T>().ToList();
    }

    public void Write<T>(IEnumerable<T> records)
    {
        using var writer = new StreamWriter(FileSavePath, false, Encoding.Latin1);
        using var csv = new CsvWriter(writer, Common.GetConfigurationWriter);

        csv.WriteRecords(records);
    }
    
    public List<T> Convert<T>(List<object> records)
    {
        var result = new List<T>();
        foreach (var record in records)
        {
            var convert = (IConvert)Activator.CreateInstance(typeof(T))!;
            convert.ConvertInit(record, convert);
            
            result.Add((T)convert);
        }

        return result;
    }
    
    public void Dispose()
    {
        File.Delete(FileTmp);
    }
}