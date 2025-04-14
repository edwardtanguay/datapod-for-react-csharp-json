#load "./Rectangle.csx"

public class Learn
{
	public static void Title(string titleNumber, string description = "")
	{
		if (description == "")
		{
			Console.WriteLine($"=== EX{titleNumber} ==========================================");
		}
		else
		{
			Console.WriteLine($"=== EX{titleNumber}: {description.ToUpper()} ==========================================");
		}
	}

	public static void EX001()
	{
		Learn.Title("001", "Basic LINQ");
		var countries = new List<string>
		{
			"USA", "Canada", "Mexico",
			"Brazil", "Argentina", "Chile",
			"Germany", "France", "Italy",
			"Japan", "China", "India",
			"Australia", "South Africa", "Egypt"
		};
		Console.WriteLine("Countries: " + string.Join(", ", countries));
		Console.WriteLine("Countries count: " + countries.Count);
		// old way to query
		Console.WriteLine("Countries with more than 6 characters:");
		foreach (var country in countries)
		{
			if (country.Length > 6)
			{
				Console.WriteLine(country);
			}
		}
		// with LINQ
		var longCountries = countries.Where(c => c.Length > 6).ToList();
		Console.WriteLine("LINQ: Countries with more than 6 characters: " + string.Join(", ", longCountries));
	}

	public static void EX002()
	{
		Learn.Title("001", "Basic class");
		var rectangle = new Rectangle(10, 20);
		Console.WriteLine($"Rectangle: Width = {rectangle.Width}, Height = {rectangle.Height}");
		Console.WriteLine($"Area: {rectangle.Area()}");
		Console.WriteLine($"Perimeter: {rectangle.Perimeter()}");

		var square = new Rectangle(10);
		Console.WriteLine($"Square: Width = {square.Width}, Height = {square.Height}");
		Console.WriteLine($"Area: {square.Area()}");
		Console.WriteLine($"Perimeter: {square.Perimeter()}");

	}
}