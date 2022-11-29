using LF08_LogFileProject.Models.Ips;

namespace LF08_LogFileProject.Models;

public class LogFile
{
    public int Id { get; set; }
    public Ip Ip { get; set; }
    public DateTime Date { get; set; }
    public Method Method { get; set; }
    public string Address { get; set; }
    public int Code { get; set; }
    public int? Attribute { get; set; }
}