using System.Text;
using CsvHelper;
using LibsExportGlobal.ExportGlobal.SStruc;

namespace LibsExportGlobal.CsvReader;

public class ExportGlobalReader : IReader, IDisposable
{
    private List<string> FilesPath { get; }
    private List<string> FilesTmp { get; set; }
    private string FileSavePath { get; set; } = null!;

    private SFilePath FileInfo { get; set; }

    private const string BaseName = "ExportGlobal_";

    public ExportGlobalReader(string filePath)
    {
        FilesTmp = new List<string>();
        FilesPath = new List<string> { filePath };
        
        Setup();
    }
    
    public ExportGlobalReader(List<string> filesPath)
    {
        FilesPath = filesPath;
        FilesTmp = new List<string>();

        Setup();
    }

    private void Setup()
    {
        FileInfo = new SFilePath(FilesPath.First());

        FileSavePath = FileInfo.GetSavePath(BaseName);
    }

    public void CleanFirstRow(int row, bool keepHeader)
    {
        foreach (var file in FilesPath)
        {
            var linesToWrite = new List<string>();
            var data = File.ReadAllLines(file, Encoding.Latin1);
            
            if (keepHeader) linesToWrite.Add(data[0]);
            linesToWrite.AddRange(data.Skip(row));

            var tempFile = Path.GetTempFileName();
            File.WriteAllLines(tempFile, linesToWrite, Encoding.Latin1);
            FilesTmp.Add(tempFile);
        }
    }

    public List<T> Read<T>()
    {
        var reads = new List<T>();

        foreach (var file in FilesTmp)
        {
            using var reader = new StreamReader(file, Encoding.Latin1);
            var csv = new CsvHelper.CsvReader(reader, Common.GetConfigurationReader);

            var records = csv.GetRecords<T>().ToList();
            
            reads.AddRange(records);
        }

        return reads;
    }

    public void Write<T>(IEnumerable<T> records)
    {
        using var writer = new StreamWriter(FileSavePath, false, Encoding.Latin1);
        using var csv = new CsvWriter(writer, Common.GetConfigurationWriter);

        csv.WriteRecords(records);
    }

    public void SetSavePath(string filePath) => FileSavePath = filePath;

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
        foreach (var file in FilesTmp) File.Delete(file);
    }
}