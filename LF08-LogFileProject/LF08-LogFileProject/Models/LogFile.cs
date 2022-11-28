namespace LF08_LogFileProject.Models;

public class LogFile
{
    public int Id { get; set; }
    public string Ip { get; set; }
    public DateTime Date { get; set; }
    public string Method { get; set; }
    public string Address { get; set; }
    public int Code { get; set; }
    public int? Attribute { get; set; }
}