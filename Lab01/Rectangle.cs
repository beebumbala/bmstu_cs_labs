namespace Lab01;

class Rectangle
{
    private double _side1;
    private double _side2;

    public double Side1
    {
        get => _side1;
        set
        {
            if (value <= 0)
                throw new Exception("Side must be greater than or equal to 0.");
            _side1 = value;
        }
    }

    public double Side2
    {
        get => _side2;
        set
        {
            if (value <= 0)
                throw new Exception("Side must be greater than or equal to 0.");
            _side2 = value;
        }
    }

    public Rectangle(double side1, double side2)
    {
        if (side1 <= 0 || side2 <= 0)
            throw new Exception("Sides must be greater than zero");

        Side1 = side1;
        Side2 = side2;
    }

    private double CalculateArea() => Side1 * Side2;
    private double CalculatePerimeter() => 2 * (Side1 + Side2);

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}