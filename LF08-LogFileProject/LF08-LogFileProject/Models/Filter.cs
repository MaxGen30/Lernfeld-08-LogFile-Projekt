namespace LF08_LogFileProject.Models;

public class Filter
{
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
    public string[]? Ips { get; set; }
    public string[]? Methods { get; set; }
    public string[]? Code { get; set; }
    public List<Attributes>? Attributes { get; set; }
}