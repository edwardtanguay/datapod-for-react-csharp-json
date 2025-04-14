#load "../qtools/qfil.csx"
#load "../qtools/qstr.csx"

public class Flashcard(string suuid, string category, string front, string back)
{
	public string Suuid { get; set; } = suuid;
	public string Category { get; set; } = category;
	public string Front { get; set; } = front;
	public string Back { get; set; } = back;

	public static void SaveToJson(List<Flashcard> flashcards, string filePath)
	{
		var options = new System.Text.Json.JsonSerializerOptions
		{
			WriteIndented = true,
			PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase
		};
		string json = System.Text.Json.JsonSerializer.Serialize(flashcards, options);
		System.IO.File.WriteAllText(filePath, json);
	}

	public static List<Flashcard> GetFlashcardsFromTextFile(string filePath)
	{
		var lines = qfil.getLinesFromFile(filePath);
		lines.Add("");
		lines.Add("");
		lines.Add("");
		var flashcards = new List<Flashcard>();

		for (int i = 0; i < lines.Count; i += 4) 
		{
			if (i + 3 < lines.Count)
			{
				var category = lines[i];
				var front = lines[i + 1];
				var back = lines[i + 2];
				var suuid = qstr.generateSuuid();
				flashcards.Add(new Flashcard(suuid, category, front, back));
			}
		}

		return flashcards;
	}

}