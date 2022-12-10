namespace LF08_LogFileProject.Models;

public enum Method
{
    Empty = 0,
    Get = 1,
    Post = 2,
    Head = 3,
}

public static class MethodUtils
{
    public static Method GetMethod(string method)
    {
        return method.ToLower() switch
        {
            "get" => Method.Get,
            "post" => Method.Post,
            "head" => Method.Head,
            _ => Method.Empty
        };
    }

    public static string GetMethodAsString(Method method)
    {
        switch (method)
        {
            case Method.Get:
                return "get";
            case Method.Head:
                return "head";
            case Method.Post:
                return "post";
            default:
                return "";
        }
    }

    public static Method GetMethod(int method)
    {
        if(method is >= 0 and <= 3) {
            return (Method)method;
        }
        return Method.Empty;
    }
}