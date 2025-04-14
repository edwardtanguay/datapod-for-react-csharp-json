public class qstr
{
	public static string generateSuuid()
	{
		var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		var random = new Random();
		var result = new string(Enumerable.Repeat(chars, 6)
			.Select(s => s[random.Next(s.Length)]).ToArray());
		return result;
	}
}

