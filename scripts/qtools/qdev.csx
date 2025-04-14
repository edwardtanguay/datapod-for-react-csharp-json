using Internal;

public static class qdev
{
    public static void debug(string line)
    {
        Console.WriteLine($"️🛠️  {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} - {line}");
    }
}