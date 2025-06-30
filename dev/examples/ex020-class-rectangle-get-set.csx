class Rectangle
{
	private double width;
	private double length;

	public double Length
	{
		get { return length; }
		set
		{
			if (value < 0)
				throw new ArgumentException("Length cannot be negative.");
			length = value;
		}
	}

	public double Width
	{
		get { return width; }
		set
		{
			if (value < 0)
				throw new ArgumentException("Width cannot be negative.");
			width = value;
		}
	}

	public string IdCode {get; set;} = Guid.NewGuid().ToString();

	public Rectangle(double length, double width)
	{
		this.Length = length;
		this.Width = width;
	}

	public double GetArea()
	{
		return Length * width;
	}
}

var h = 5.6;
var l = 3.1;

try 
{
	var rect = new Rectangle(h, l);
	rect.IdCode = "Rect-001"; // Example of setting the IdCode property
	Console.WriteLine($"Area of rectangle: {rect.GetArea():F2}");
	Console.WriteLine($"Rectangle ID: {rect.IdCode}");
}
catch (ArgumentException ex)
{
	Console.WriteLine($"Error: {ex.Message}");
}