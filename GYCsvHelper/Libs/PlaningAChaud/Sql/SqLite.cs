using System.Data.SQLite;

namespace Libs.PlaningAChaud.Sql;

public class SqLite
{
    private static SQLiteConnection _connection = null!;

    public SqLite(string filePath)
    {
        _connection = new SQLiteConnection($"Data Source={Path.GetFullPath(filePath)}");
        _connection.Open();
    }

    internal static void Disconnection() => _connection.Close();

    internal string SqlNull(string? str) => string.IsNullOrEmpty(str) ? "NULL" : str.Replace("'", "''");

    internal void Execute(string cmd) => new SQLiteCommand(cmd, _connection).ExecuteNonQuery();
    
    internal SQLiteDataReader ExecuteReader(string cmd) => new SQLiteCommand(cmd, _connection).ExecuteReader();
}