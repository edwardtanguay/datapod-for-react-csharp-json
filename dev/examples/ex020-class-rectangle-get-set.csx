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

var h = -5.6;
var l = 3.1;

try 
{
	var rect = new Rectangle(h, l);
	Console.WriteLine($"Area of rectangle: {rect.GetArea():F2}");
}
catch (ArgumentException ex)
{
	Console.WriteLine($"Error: {ex.Message}");
}