namespace Lab02.vehicles;

public class Ship : Vehicle
{
    private int Passengers;
    private string Port;

    public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
        : base(x, y, price, speed, year)
    {
        Passengers = passengers;
        Port = port;
    }

    public override void Info() =>
        Console.WriteLine($"ship: position=({X},{Y}) price={Price} speed={Speed} year={Year} passengers={Passengers} port={Port}");
}
