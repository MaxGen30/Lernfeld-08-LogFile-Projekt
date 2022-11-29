namespace LF08_LogFileProject.Models;

public class InsertResult
{
    public bool Success { get; set; }

    public List<InsertError> Errors { get; set; }

    public InsertResult()
    {
        Success = true;
        Errors = new List<InsertError>();
    }

    public void AddError(int index, Exception exception)
    {
        Success = false;
        var error = new InsertError(index, exception);
        Errors.Add(error);
    }
    
    public void AddError(int index, string message)
    {
        Success = false;
        var error = new InsertError(index, message);
        Errors.Add(error);
    }
}