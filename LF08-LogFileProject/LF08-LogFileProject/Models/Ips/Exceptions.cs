namespace LF08_LogFileProject.Models.Ips;

public class WrongIpFormatException: Exception
{
    public WrongIpFormatException(string message): base(message) {}
}

public class InvalidIpValueException : Exception
{
    public InvalidIpValueException(string message): base(message) {}
}