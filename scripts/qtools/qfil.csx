using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class qfil
{
    public static List<string> getLinesFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"The file '{filePath}' does not exist.");
        }

        return File.ReadAllLines(filePath).ToList(); // Convert array to List<string>
    }
}

