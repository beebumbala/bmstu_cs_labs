namespace Lab02.vehicles;

public class Car : Vehicle
{
    public Car(double x, double y, double price, double speed, int year)
        : base(x, y, price, speed, year) { }

    public override void Info() =>
        Console.WriteLine($"car: position=({X},{Y}) price={Price} speed={Speed} year={Year}");
}
