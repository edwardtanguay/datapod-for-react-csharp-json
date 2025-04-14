class Rectangle
{
	public int Width { get; set; }
	public int Height { get; set; }

	public Rectangle(int width, int height)
	{
		Width = width;
		Height = height;
	}

	public Rectangle(int size)
	{
		Width = size;
		Height = size;
	}

	public int Area()
	{
		return Width * Height;
	}

	public int Perimeter()
	{
		return 2 * (Width + Height);
	}
}