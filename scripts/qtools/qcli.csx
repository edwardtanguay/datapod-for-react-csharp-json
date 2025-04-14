using System;

public static class qcli
{
    public static void message(string line, string kind)
    {
        string prefix = kind switch
        {
            "info" => "ℹ️  ",
            "error" => "❌ ",
            "warning" => "⚠️  ",
            "doing" => "⏳ ",
            "ball" => "🟠 ",
            "star" => "⭐ ",
            _ => "✅ "
        };

        Console.WriteLine($" {prefix}{line}");
    }
}