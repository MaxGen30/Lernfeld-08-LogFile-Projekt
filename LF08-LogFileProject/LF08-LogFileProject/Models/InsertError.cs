namespace LF08_LogFileProject.Models;

public class InsertError
{
    public int Index { get; set; }
    public string ExceptionMessage { get; set; }

    public InsertError(int index, Exception exception)
    {
        Index = index;
        ExceptionMessage = exception.Message;
    }
}