using System.Data.Common;
using System.Data.SQLite;
using System.Globalization;
using System.Reflection;
using System.Text;
using LF08_LogFileProject.Models;
using LF08_LogFileProject.Models.Ips;

namespace LF08_LogFileProject;

public class Database
{
    private SQLiteConnection Connection;
    private ListError _listError;

    public Database(ListError listError)
    {
        Init();
        _listError = listError;
    }

    private void Init()
    {
        var filePath = Path.GetDirectoryName(new Uri(Assembly.GetEntryAssembly()!.Location).LocalPath) +
                       "/LogDb.sqlite";

        if (!File.Exists(filePath))
        {
            SQLiteConnection.CreateFile("LogDb.sqlite");
            Connection = new SQLiteConnection("Data Source=LogDb.sqlite;Version=3;");
            Connection.Open();

            CreateLogFileTable();
        }
        else
        {
            Connection = new SQLiteConnection("Data Source=LogDb.sqlite;Version=3;");
            Connection.Open();
        }
    }

    private void CreateLogFileTable()
    {
        var query = new StringBuilder(@"
                        create table logs
                        (
                            id        INTEGER     not null
                                primary key autoincrement
                                unique,
                            ip        varchar(15) not null,
                            date      TEXT        not null,
                            ticks     integer     not null,
                            method    INTEGER     not null,
                            address   TEXT        not null,
                            code      INTEGER     not null,
                            response_time INTEGER,
                            unique (ip, date, ticks)
                            );
");

        var command = new SQLiteCommand(query.ToString(), Connection);
        command.ExecuteNonQuery();
    }

    public async Task StopConnection()
    {
        await Connection.CloseAsync();
    }

    public async Task<InsertResult> Insert(string path)
    {
        var result = new InsertResult();

        var lines = File.ReadLines(path);

        var files = new List<LogFile>();

        var index = 0;
        foreach (var line in lines)
        {
            var values = line.Split(" ");

            if (values.Length is < 9 or > 10)
            {
                _listError.AddError(index, "Ungültige Menge an Werten");
                index++;
                continue;
            }

            // catch error
            Ip ip;
            try
            {
                ip = new Ip(values[0]);
            }
            catch (Exception e)
            {
                result.AddError(index, e);
                _listError.AddError(index, "Ungültige Ip");
                index++;
                continue;
            }

            DateTime dateTime;
            int ticks;
            try
            {
                var dateString = values[3];
                var timeString = values[4];
                dateString = dateString.Replace("[", "");
                timeString = timeString.Replace("]", "");

                var dateValues = dateString.Split("-");
                var timeValues = timeString.Split(":");

                // catch errors
                var yearSuccess = Int32.TryParse(dateValues[0], out var year);
                var monthSuccess = Int32.TryParse(dateValues[1], out var month);
                var daySuccess = Int32.TryParse(dateValues[2], out var day);

                bool timeSucess = true;
                timeSucess = Int32.TryParse(timeValues[0], out var hours);
                timeSucess = Int32.TryParse(timeValues[1], out var minutes);
                var milliAndSeconds = timeValues[2].Split(".");
                timeSucess = Int32.TryParse(milliAndSeconds[0], out var seconds);

                var millisecondString = new StringBuilder(milliAndSeconds[1]);


                timeSucess = Int32.TryParse(millisecondString.ToString(0, 3), out int milliSeconds);
                timeSucess = Int32.TryParse(millisecondString.ToString(3, 3), out ticks);

                dateTime = new DateTime(year, month, day, hours, minutes, seconds, milliSeconds);
            }
            catch (Exception e)
            {
                result.AddError(index, e);
                _listError.AddError(index, "Ungültiges Datum");
                index++;
                continue;
            }

            var methodString = values[5].Replace("\"", "");
            Method method = MethodUtils.GetMethod(methodString);
            if (method == Method.Empty)
            {
                _listError.AddError(index, "Ungültige Methode");
                index++;
                continue;
            }

            var address = values[6].Replace("\"", "") + " " + values[7].Replace("\"", "");

            // catch error
            var codeSuccess = Int32.TryParse(values[8], out var code);

            if (!codeSuccess || code < 0 || code > 999)
            {
                _listError.AddError(index, "Ungültiger Statuscode");
                index++;
                continue;
            }

            // catch error
            int? attribute = null;
            if (values.Length > 9)
            {
                var attributeSuccess = Int32.TryParse(values[9], out var attributeResult);
                if (!attributeSuccess && values[9] != "-")
                {
                    _listError.AddError(index, "Ungültige Antwortzeit");
                    index++;
                    continue;
                }

                attribute = attributeResult;
            }

            LogFile log = new LogFile();
            log.Ip = ip;
            log.Date = dateTime;
            log.Ticks = ticks;
            log.Method = method;
            log.Address = address;
            log.Code = code;
            log.ResponseTime = attribute;

            files.Add(log);
            
            // add into logs table
            try
            {
                if (index == 151)
                {
                    var a = 1;
                }
                
                var query = new StringBuilder(@"
                        INSERT INTO
                            logs(ip, date, ticks, method, address, code, response_time)
                        VALUES
                            (@ip, @date, @ticks, @method, @address, @code, @response_time);");

                var command = new SQLiteCommand(query.ToString(), Connection);
                command.Parameters.AddWithValue("ip", log.Ip.ToString());
                command.Parameters.AddWithValue("date", log.Date);
                command.Parameters.AddWithValue("ticks", log.Ticks);
                command.Parameters.AddWithValue("method", log.Method);
                command.Parameters.AddWithValue("address", log.Address);
                command.Parameters.AddWithValue("code", log.Code);
                command.Parameters.AddWithValue("response_time", log.ResponseTime);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                result.AddError(index, "Could not insert into Logs Table");
                _listError.AddError(index, e.Message);
                index++;
                continue;
            }


            index++;
        }

        _listError.lastDisplay();
        return result;
    }

    /// <summary>
    /// Analyse 1
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public async Task<List<LogFile>> GetLogFilesAsync(Filter filter)
    {
        var query = new StringBuilder("SELECT id, ip, date, method, address, code, response_time  FROM logs");

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
            logFile.Ip = GetIp(reader, 1)!;
            logFile.Date = DateTime.Parse(reader.GetString(2));
            logFile.Method = MethodUtils.GetMethod(reader.GetInt32(3));
            logFile.Address = reader.GetString(4);
            logFile.Code = reader.GetInt32(5);
            logFile.ResponseTime = GetIntNullable(reader, 6);

            results.Add(logFile);
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

            results.Add(value);
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

            var method = MethodUtils.GetMethod(reader.GetInt32(0));
            value.Value = MethodUtils.GetMethodAsString(method);
            value.Amount = reader.GetInt32(1);

            results.Add(value);
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
        var query = new StringBuilder("SELECT code, COUNT(*) as amount  FROM logs");

        var command = new SQLiteCommand();
        command.Connection = Connection;

        var statements = CreateFilterStatements(filter, command.Parameters).ToList();

        if (statements.Any())
        {
            query.Append(" WHERE ");
            query.AppendJoin(" AND ", statements);
        }

        query.Append(" GROUP BY code;");

        command.CommandText = query.ToString();

        await using var reader = await command.ExecuteReaderAsync();

        var results = new List<ValueAmounts<string>>();

        while (await reader.ReadAsync())
        {
            var value = new ValueAmounts<string>();

            var code = reader.GetInt32(0);
            value.Value = code.ToString();
            value.Amount = reader.GetInt32(1);

            results.Add(value);
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
        if (!filter.UseFilter)
        {
            yield break;
        }

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

        if (filter.Ips is { Count: > 0 })
        {
            var ips = CreateValueList(filter.Ips, parameters);
            var statement = new StringBuilder("ip in ( ");
            statement.AppendJoin(" , ", ips);
            statement.Append(" )");
            yield return statement.ToString();
        }

        if (filter.FilterMethods)
        {
            var methods = CreateValueList(filter.Methods, parameters);
            var statement = new StringBuilder("method in ( ");
            statement.AppendJoin(" , ", methods);
            statement.Append(" )");
            yield return statement.ToString();
        }

        if (filter.FilterCodes)
        {
            var codes = CreateValueList(filter.Codes, parameters);
            var statement = new StringBuilder("code in ( ");
            statement.AppendJoin(" , ", codes);
            statement.Append(" )");
            yield return statement.ToString();
        }
    }

    private IEnumerable<string> CreateValueList<T>(List<T> values, SQLiteParameterCollection parameters)
    {
        foreach (var value in values)
        {
            var index = parameters.Count;
            parameters.AddWithValue($"filter{index}", value);
            yield return $"@filter{index}";
        }
    }

    private IEnumerable<string> CreateValueList(List<Ip> values, SQLiteParameterCollection parameters)
    {
        foreach (var value in values)
        {
            var index = parameters.Count;
            parameters.AddWithValue($"filter{index}", value.ToString());
            yield return $"@filter{index}";
        }
    }

    private int? GetIntNullable(DbDataReader reader, int index)
    {
        return reader.IsDBNull(index) ? null : reader.GetInt32(index);
    }

    private Ip? GetIp(DbDataReader reader, int index)
    {
        // ADD MORE PROTECTION HERE
        return new Ip(reader.GetString(index));
    }
}