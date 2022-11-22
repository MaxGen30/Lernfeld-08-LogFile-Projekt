using System.Data.SQLite;
using System.Text;
using LF08_LogFileProject.Models;

namespace LF08_LogFileProject;

public class Database
{
    private SQLiteConnection Connection; 
    
    public Database()
    {
        
    }

    public async Task CreateLogFileDb()
    {
        // TODO Check if Db already exists
        
        SQLiteConnection.CreateFile("LogDb.sqlite");
        
        Connection = new SQLiteConnection("Data Source=LogDb.sqlite;Version=3;");
    }

    public async Task CreateLogFileTable()
    {
       // TODO Check if Table already exists

       StringBuilder query = new StringBuilder(@"
                        CREATE TABLE logs
                        (
                            id      INTEGER     not null
                                primary key autoincrement
                                unique,
                            ip      varchar(15) not null,
                            date    INTEGER     not null,
                            method  varchar(20) not null,
                            address TEXT        not null
                        );

                        CREATE TABLE attributes
                        (
                            id        INTEGER not null
                                primary key autoincrement
                                unique,
                            log_id    INTEGER not null
                                constraint logs___fk
                                    references logs,
                            attribute INTEGER not null
                        );");
       
       var command = new SQLiteCommand(query.ToString(), Connection);
       command.ExecuteNonQuery();
    }

    public async Task StopConnection()
    {
        await Connection.CloseAsync();
    }

    /// <summary>
    /// Analyse 1
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public async Task<List<LogFile>> GetLogFilesAsync(Filter filter)
    {
        // TODO Select fertig schreiben
        var query = new StringBuilder("SELECT * FROM logs");

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
            results.Append(new LogFile());
        }
        
        return results;
    }

    /// <summary>
    /// Analyse 2
    /// </summary>
    /// <param name="filter">filter</param>
    /// <returns></returns>
    public async Task<List<LogFile>> GetAmountOfAccessesPerIpAsync(Filter filter)
    {
        return new List<LogFile>();
    }

    /// <summary>
    /// Analyse 3
    /// </summary>
    /// <param name="filter">filter</param>
    /// <returns></returns>
    public async Task<List<LogFile>> GetAmountOfEntriesPerRequestMethods(Filter filter)
    {
        return new List<LogFile>();
    }

    /// <summary>
    /// Analyse 4
    /// </summary>
    /// <param name="filter">filter</param>
    /// <returns></returns>
    public async Task<List<LogFile>> GetAmountOfEntriesPerErrorCode(Filter filter)
    {
        return new List<LogFile>();
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
}