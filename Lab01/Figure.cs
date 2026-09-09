namespace Lab01;

class Figure
{
    private readonly List<Point> points;

    public string Name { get; }

    public Figure(Point a, Point b, Point c)
    {
        points = new List<Point> { a, b, c };
        Name = "Triangle";
    }

    public Figure(Point a, Point b, Point c, Point d) : this(a, b, c)
    {
        points.Add(d);
        Name = "Quadrangle";
    }

    public Figure(Point a, Point b, Point c, Point d, Point e) : this(a, b, c, d)
    {
        points.Add(e);
        Name = "Pentagon";
    }

    public double LengthSide(Point a, Point b)
    {
        return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
    }

    public double PerimeterCalculator()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Count; i++)
        {
            perimeter += LengthSide(points[i], points[(i + 1) % points.Count]);
        }

        return perimeter;
    }
}