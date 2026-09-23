namespace Lab02.vehicles;

public class Vehicle
{
    public double X, Y;
    public double Price;
    public double Speed;
    public int Year;

    public Vehicle(double x, double y, double price, double speed, int year)
    {
        X = x;
        Y = y;
        Price = price;
        Speed = speed;
        Year = year;
    }

    public virtual void Info() =>
        Console.WriteLine($"vehicle: position=({X},{Y}) price={Price} speed={Speed} year={Year}");
}