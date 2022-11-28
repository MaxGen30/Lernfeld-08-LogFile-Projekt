namespace LF08_LogFileProject.Models.Ips;

public class Ip
{
    private readonly int[] _addresses = new int[4];

    public Ip(string ip)
    {
        var array = ip.Split(".");

        if (array.Length != 4)
        {
            throw new WrongIpFormatException("Ip format is wrong");
        }


        for (int i = 0; i < _addresses.Length; i++)
        {
            var success = Int32.TryParse(array[i], out var address);

            if (!success || address is < 0 or > 255)
            {
                throw new InvalidIpValueException($"Address at Position {i+1} is invalid");
            }

            _addresses[i] = address;
        }
    }

    public string GetIp()
    {
        return _addresses[0] + "." + _addresses[1] + "." + _addresses[2] + "." + _addresses[3];
    }
}