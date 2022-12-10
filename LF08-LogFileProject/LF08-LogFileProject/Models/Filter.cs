namespace LF08_LogFileProject.Models;

public class Filter
{
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
    public List<string>? Ips { get; set; }

    // Methods
    public bool FilterMethods = false;
    public List<Method> Methods = new List<Method>();
    
    // Codes
    public bool FilterCodes = false;
    public List<int> Codes = new List<int>();
    
    public bool ShowAllAttributes { get; set; }
    public List<Attributes>? Attributes { get; set; }
    public bool UseFilter { get; set; }
}