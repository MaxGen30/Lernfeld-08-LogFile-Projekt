using System.Data.Common;
using System.Data.SQLite;
using System.Reflection;
using System.Text;
using LF08_LogFileProject.Models;

namespace LF08_LogFileProject;

public class Database
{
    private SQLiteConnection Connection;

    public Database()
    {
        Init();
    }

    private void Init()
    {
        var filePath = Path.GetDirectoryName(new Uri(Assembly.GetEntryAssembly()!.Location).LocalPath)+ "/LogDb.sqlite";

        if (!File.Exists(filePath))
        {

            SQLiteConnection.CreateFile("LogDb.sqlite");
            Connection = new SQLiteConnection("Data Source=LogDb.sqlite;Version=3;");

            CreateLogFileTable();
        }
        else
        {
            Connection = new SQLiteConnection("Data Source=LogDb.sqlite;Version=3;");
        }
    }

    private void CreateLogFileTable()
    {
       var query = new StringBuilder(@"
                        CREATE TABLE logs
                            (
                                id        INTEGER     not null
                                    constraint logs_pk
                                        primary key autoincrement,
                                ip        varchar(15) not null,
                                date      INTEGER     not null,
                                method    varchar(20) not null,
                                address   TEXT        not null,
                                code      INTEGER     not null,
                                attribute INTEGER
                            );");
       
       var command = new SQLiteCommand(query.ToString(), Connection);
       command.ExecuteNonQuery();
    }

    public async Task StopConnection()
    {
        await Connection.CloseAsync();
    }

    public async Task<InsertResult> Insert()
    {
        var result = new InsertResult();
        
        var filePath = Path.GetDirectoryName(new Uri(Assembly.GetEntryAssembly()!.Location).LocalPath)+ "/log.txt";

        var content = await File.ReadAllTextAsync(filePath);

        var lines = content.Split(Environment.NewLine);

        for (int i = 0; i < lines.Length; i++)
        {
            var valueArray = lines[i].Split(" ");
            List<string> values = new List<string>(valueArray);
        }

        return result;
    }

    /// <summary>
    /// Analyse 1
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public async Task<List<LogFile>> GetLogFilesAsync(Filter filter)
    {
        var query = new StringBuilder("SELECT id, ip, date, method, address, 'code', 'attribute'  FROM logs");

        var command = new SQLiteCommand();
        command.Connection = Connection;
        
        var statements = CreateFilterStatements(filter, command.Parameters).ToList();

        if (statements.Any())
        {
            query.Append(" WHERE ");
            query.AppendJoin(" AND ", statements);
        }

        command.CommandText = query.ToString();
        
        await using var reader = await command.ExecuteReaderAsync();

        var results = new List<LogFile>();
        
        while (await reader.ReadAsync())
        {
            var logFile = new LogFile();
            
            logFile.Id = reader.GetInt32(0);
            logFile.Ip = reader.GetString(1);
            logFile.Date = new DateTime(reader.GetInt32(2));
            logFile.Method = reader.GetString(3);
            logFile.Address = reader.GetString(4);
            logFile.Code = reader.GetInt32(5);
            logFile.Attribute = GetIntNullable(reader, 6);
            
            results.Add(new LogFile());
        }
        
        return results;
    }

    /// <summary>
    /// Analyse 2
    /// </summary>
    /// <param name="filter">filter</param>
    /// <returns></returns>
    public async Task<List<ValueAmounts<string>>> GetAmountOfAccessesPerIpAsync(Filter filter)
    {
        var query = new StringBuilder("SELECT ip, COUNT(*) as amount  FROM logs");

        var command = new SQLiteCommand();
        command.Connection = Connection;
        
        var statements = CreateFilterStatements(filter, command.Parameters).ToList();

        if (statements.Any())
        {
            query.Append(" WHERE ");
            query.AppendJoin(" AND ", statements);
        }

        query.Append(" GROUP BY ip;");

        command.CommandText = query.ToString();
        
        await using var reader = await command.ExecuteReaderAsync();

        var results = new List<ValueAmounts<string>>();
        
        while (await reader.ReadAsync())
        {
            var value = new ValueAmounts<string>();

            value.Value = reader.GetString(0);
            value.Amount = reader.GetInt32(1);
        }
        
        return results;
    }

    /// <summary>
    /// Analyse 3
    /// </summary>
    /// <param name="filter">filter</param>
    /// <returns></returns>
    public async Task<List<ValueAmounts<string>>> GetAmountOfEntriesPerRequestMethods(Filter filter)
    {
        var query = new StringBuilder("SELECT method, COUNT(*) as amount  FROM logs");

        var command = new SQLiteCommand();
        command.Connection = Connection;
        
        var statements = CreateFilterStatements(filter, command.Parameters).ToList();

        if (statements.Any())
        {
            query.Append(" WHERE ");
            query.AppendJoin(" AND ", statements);
        }

        query.Append(" GROUP BY method;");

        command.CommandText = query.ToString();
        
        await using var reader = await command.ExecuteReaderAsync();

        var results = new List<ValueAmounts<string>>();
        
        while (await reader.ReadAsync())
        {
            var value = new ValueAmounts<string>();

            value.Value = reader.GetString(0);
            value.Amount = reader.GetInt32(1);
        }
        
        return results;
    }

    /// <summary>
    /// Analyse 4
    /// </summary>
    /// <param name="filter">filter</param>
    /// <returns></returns>
    public async Task<List<ValueAmounts<string>>> GetAmountOfEntriesPerErrorCode(Filter filter)
    {
        var query = new StringBuilder("SELECT 'code', COUNT(*) as amount  FROM logs");

        var command = new SQLiteCommand();
        command.Connection = Connection;
        
        var statements = CreateFilterStatements(filter, command.Parameters).ToList();

        if (statements.Any())
        {
            query.Append(" WHERE ");
            query.AppendJoin(" AND ", statements);
        }

        query.Append(" GROUP BY 'code;");

        command.CommandText = query.ToString();
        
        await using var reader = await command.ExecuteReaderAsync();

        var results = new List<ValueAmounts<string>>();
        
        while (await reader.ReadAsync())
        {
            var value = new ValueAmounts<string>();

            value.Value = reader.GetInt32(0).ToString();
            value.Amount = reader.GetInt32(1);
        }
        
        return results;
    }

    /// <summary>
    /// creates the separate filter statements needed for the sql query
    /// </summary>
    /// <param name="filter">filter</param>
    /// <param name="parameters">parameters</param>
    /// <returns>an enumerable of filter statements</returns>
    private IEnumerable<string> CreateFilterStatements(Filter filter, SQLiteParameterCollection parameters)
    {
        if (filter.Start.HasValue)
        {
            var start = new DateTimeOffset(filter.Start.Value).ToUnixTimeMilliseconds();
            parameters.AddWithValue("start", start);
            yield return "date >= @start";
        }

        if (filter.End.HasValue)
        {
            var end = new DateTimeOffset(filter.End.Value).ToUnixTimeMilliseconds();
            parameters.AddWithValue("end", end);
            yield return "date <= @end";
        }

        if (filter.Ips is { Length: > 0 })
        {
            var ips = CreateValueList(filter.Ips, parameters);
            var statement = new StringBuilder("ip in ( ");
            statement.AppendJoin(" , ", ips);
            statement.Append(" )");
        }

        if (filter.Attributes is { Length: > 0 })
        {
            var attributes = CreateValueList(filter.Attributes, parameters);
            var statement = new StringBuilder("attribute in ( ");
            statement.AppendJoin(" , ", attributes);
            statement.Append(" )");
        }

        if (filter.Methods is { Length: > 0 })
        {
            var methods = CreateValueList(filter.Methods, parameters);
            var statement = new StringBuilder("method in ( ");
            statement.AppendJoin(" , ", methods);
            statement.Append(" )");
        }

        if (filter.Code is { Length: > 0 })
        {
            var codes = CreateValueList(filter.Code, parameters);
            var statement = new StringBuilder("code in ( ");
            statement.AppendJoin(" , ", codes);
            statement.Append(" )");
        }
    }

    private IEnumerable<string> CreateValueList(string[] filter, SQLiteParameterCollection parameters)
    {
        for (int i = 0; i < filter.Length; i++)
        {
            parameters.AddWithValue($"filter{i}", filter[i]);
            yield return $"@filter{i}";
        }   
    }

    private int? GetIntNullable(DbDataReader reader, int index)
    {
        return reader.IsDBNull(index) ? null : reader.GetInt32(index);
    }
}