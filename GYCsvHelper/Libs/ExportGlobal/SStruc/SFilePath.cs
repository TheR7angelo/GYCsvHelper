namespace Libs.ExportGlobal.SStruc;

public struct SFilePath
{
    public string FilePath { get; }
    public string FileName { get; }
    public string FileExtension { get; }

    public SFilePath(string filePath)
    {
        FilePath = Path.GetDirectoryName(filePath)!;
        FileName = Path.GetFileNameWithoutExtension(filePath);
        FileExtension = Path.GetExtension(filePath);
    }
}