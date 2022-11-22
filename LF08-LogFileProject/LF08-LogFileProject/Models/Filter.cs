namespace LF08_LogFileProject.Models;

public class Filter
{
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
    public string? Ip { get; set; }
    public string[]? Attribute { get; set; }
    public string[]? Method { get; set; }
    public string[]? Errors { get; set; }
}