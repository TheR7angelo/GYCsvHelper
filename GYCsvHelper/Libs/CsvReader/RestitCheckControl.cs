using System.Text;
using CsvHelper;
using Libs.SStruc;

namespace Libs.CsvReader;

public class RestitCheckControl : IReader, IDisposable
{
    private string FilePath { get; }
    private string FileTmp { get; }
    private string FileSavePath { get; }
    
    private SFilePath FileInfo { get; }

    private const string BaseName = "Restitution_Fiches_Validees_complet_";

    public RestitCheckControl(string filePath)
    {
        FilePath = filePath;
        FileInfo = new SFilePath(filePath);
        
        FileSavePath = GetSavePath();
        FileTmp = Path.GetTempFileName();
    }

    private string GetSavePath()
    {
        var date = DateTime.Now;
        
        return Path.Join(FileInfo.FilePath, $"{BaseName}{date:yyyy-MM-dd}{FileInfo.FileExtension}");
    }

    public void CleanFirstRow(int row, bool keepHeader)
    {
        var data = File.ReadAllLines(FilePath);

        var linesToWrite = new List<string>();
        IEnumerable<string> lines;
        if (keepHeader) linesToWrite.Add(data[0]);
        linesToWrite.AddRange(data.Skip(row));
        
        File.WriteAllLines(FileTmp, linesToWrite);
    }
    
    public List<T> Read<T>()
    {
        using var reader = new StreamReader(FileTmp);
        var csv = new CsvHelper.CsvReader(reader, Common.GetConfigurationReader);
        
        return csv.GetRecords<T>().ToList();
    }

    public void Write<T>(IEnumerable<T> records)
    {
        using var writer = new StreamWriter(FileSavePath, Encoding.Latin1, new FileStreamOptions { Access = FileAccess.Write });
        using var csv = new CsvWriter(writer, Common.GetConfigurationWriter);

        csv.WriteRecords(records);
    }
    
    public void Dispose()
    {
        File.Delete(FileTmp);
    }

    public List<T> Convert<T>(List<object> records)
    {
        var result = new List<T>();
        foreach (var record in records)
        {
            var p = (T)Activator.CreateInstance(typeof(T), record)!;
            result.Add(p);
        }

        return result;
    }
}