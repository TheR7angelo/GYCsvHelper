namespace Libs.CsvReader;

public interface IReader
{
    public List<T> Read<T>();

    public List<T> Convert<T>(List<object> records);
}