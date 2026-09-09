namespace Lab01;

public class Program
{
    static void Main()
    {
        ShowLimits();

        Console.WriteLine();
        TestRectangle();

        Console.WriteLine();
        TestFigure();
    }

    static void ShowLimits()
    {
        Console.WriteLine("Task 1. CTS limits\n");

        Console.WriteLine("C# Type  CTS Type  Min ... Max");
        Console.WriteLine(new string('-', 35));

        PrintLimit("sbyte", typeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        PrintLimit("byte", typeof(byte), byte.MinValue, byte.MaxValue);
        PrintLimit("short", typeof(short), short.MinValue, short.MaxValue);
        PrintLimit("ushort", typeof(ushort), ushort.MinValue, ushort.MaxValue);
        PrintLimit("int", typeof(int), int.MinValue, int.MaxValue);
        PrintLimit("uint", typeof(uint), uint.MinValue, uint.MaxValue);
        PrintLimit("long", typeof(long), long.MinValue, long.MaxValue);
        PrintLimit("ulong", typeof(ulong), ulong.MinValue, ulong.MaxValue);
        PrintLimit("float", typeof(float), float.MinValue, float.MaxValue);
        PrintLimit("double", typeof(double), double.MinValue, double.MaxValue);
        PrintLimit("decimal", typeof(decimal), decimal.MinValue, decimal.MaxValue);
        PrintLimit("char", typeof(char), (int)char.MinValue, (int)char.MaxValue);
        PrintLimit("boolean", typeof(bool), bool.FalseString, bool.TrueString);
    }

    static void PrintLimit(string csName, Type ctsType, object min, object max)
    {
        Console.WriteLine($"{csName,-9}{ctsType.Name,-10}{min} ... {max}");
    }

    static void TestRectangle()
    {
        Console.WriteLine("Task 2. Rectangle test\n");

        var rectangle = new Rectangle(4, 3);
        Console.WriteLine($"Rectangle {rectangle.Side1} x {rectangle.Side2}");
        Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
        Console.WriteLine($"Area: {rectangle.Area}\n");

        rectangle.Side2 = 5;
        Console.WriteLine($"After Side2 change 3->5: perimeter {rectangle.Perimeter}, area {rectangle.Area}");
    }

    static void TestFigure()
    {
        Console.WriteLine("Task 3. Point and Figure test\n");

        var a = new Point(0, 0);
        var b = new Point(4, 0);
        var c = new Point(4, 3);
        var d = new Point(0, 3);
        var e = new Point(-2, 5);

        var triangle = new Figure(a, b, c);
        var quadrangle = new Figure(a, b, c, d);
        var pentagon = new Figure(a, b, c, d, e);

        PrintFigure(triangle);
        PrintFigure(quadrangle);
        PrintFigure(pentagon);
        
        Console.WriteLine($"Length of AB side of triangle: {triangle.LengthSide(a, b)}\n");
    }

    static void PrintFigure(Figure figure)
    {
        Console.WriteLine($"{figure.Name}: perimeter {figure.PerimeterCalculator():F2}");
    }
}