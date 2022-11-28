namespace LF08_LogFileProject.Models;

public class ValueAmounts<T>
{
    public T Value { get; set; }
    public int Amount { get; set; }

    public string GetValueAsString()
    {
        if (Value == null)
        {
            return "no value found";
        }

        if (typeof(T) == typeof(int) || typeof(T) == typeof(string))
        {
            return Value.ToString()!;
        }

        if (typeof(T) == typeof(Method))
        {
            var value = (Method)(object)Value;

            return value switch
            {
                Method.Get => "Get",
                Method.Post => "Post",
                Method.Head => "Head",
                _ => "Undefined Method"
            };
        }

        return "incompatible type";
    }
}