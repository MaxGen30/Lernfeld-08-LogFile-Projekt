using System.Data.SQLite;
using LF08_LogFileProject.Models;

namespace LF08_LogFileProject;

public class Database
{
    public Database()
    {
        CreateNewDatabase();
    }

    public void CreateNewDatabase()
    {
        SQLiteConnection.CreateFile("LogDb.sqlite");

        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=LogDb.sqlite;Version=3;");
        m_dbConnection.Open();

        string sql = "create table highscores (name varchar(20), score int)";

        SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
        command.ExecuteNonQuery();

        sql = "insert into highscores (name, score) values ('Me', 9001)";

        command = new SQLiteCommand(sql, m_dbConnection);
        command.ExecuteNonQuery();

        m_dbConnection.Close();
    }

    /// <summary>
    /// Analyse 1
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public async Task<List<LogFiles>> GetLogFilesAsync(Filter filter)
    {
        return new List<LogFiles>();
    }

    /// <summary>
    /// Analyse 2
    /// </summary>
    /// <param name="filter">filter</param>
    /// <returns></returns>
    public async Task<List<LogFiles>> GetAmountOfAccessesPerIpAsync(Filter filter)
    {
        return new List<LogFiles>();
    }

    /// <summary>
    /// Analyse 3
    /// </summary>
    /// <param name="filter">filter</param>
    /// <returns></returns>
    public async Task<List<LogFiles>> GetAmountOfEntriesPerRequestMethods(Filter filter)
    {
        return new List<LogFiles>();
    }

    /// <summary>
    /// Analyse 4
    /// </summary>
    /// <param name="filter">filter</param>
    /// <returns></returns>
    public async Task<List<LogFiles>> GetAmountOfEntriesPerErrorCode(Filter filter)
    {
        return new List<LogFiles>();
    }

    /// <summary>
    /// creates the separate filter statements needed for the sql query
    /// </summary>
    /// <param name="filter">filter</param>
    /// <returns>an enumerable of filter statements</returns>
    private IEnumerable<string> CreateFilterStatements(Filter filter, SQLiteParameterCollection parameters)
    {
        if (filter.Start.HasValue)
        {
            
        }

        if (filter.End.HasValue)
        {
            
        }

        if (filter.Ip != null)
        {
            
        }

        if (filter.Attribute is { Length: > 0 })
        {
            
        }

        if (filter.Method is { Length: > 0 })
        {
            
        }

        if (filter.Errors is { Length: > 0 })
        {
            
        }
        
        yield break;
    }
}