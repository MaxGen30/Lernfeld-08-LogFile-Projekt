namespace LF08_LogFileProject.Models.Ips;

public enum Errors
{
    NoError = 0,
    StartBiggerThanEnd = 1,
    NoIps = 3,
    NoCodes = 4,
    InvalidBegin,
    InvalidEnd,
    FailedToRead,
    DeleteIpError,
    InvalidIp,
    NoAttributesSelected,
}