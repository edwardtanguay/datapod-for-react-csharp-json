class Rectangle
{
	private double length;
	private double width;

	public Rectangle(double length, double width)
	{
		this.length = length;
		this.width = width;
	}

	public double GetArea()
	{
		return length * width;
	}
}

var rect = new Rectangle(5.0, 3.2);
Console.WriteLine($"Area of rectangle: {rect.GetArea()}");