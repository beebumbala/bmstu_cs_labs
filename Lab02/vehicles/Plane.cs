namespace Lab02.vehicles;

public class Plane : Vehicle
{
    private double Height;
    private int Passengers;

    public Plane(double x, double y, double price, double speed, int year, double height, int passengers)
        : base(x, y, price, speed, year)
    {
        Height = height;
        Passengers = passengers;
    }

    public override void Info() =>
        Console.WriteLine($"plane: position=({X},{Y}) price={Price} speed={Speed} year={Year} height={Height} passengers={Passengers}");
}
