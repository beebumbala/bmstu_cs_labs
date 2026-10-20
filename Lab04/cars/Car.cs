namespace Lab04.cars;

public class Car
{
    public string Name { get; set; }
    public int ProductionYear { get; set; }
    public double MaxSpeed { get; set; }

    public Car(string name, int productionYear, double maxSpeed)
    {
        Name = name;
        ProductionYear = productionYear;
        MaxSpeed = maxSpeed;
    }

    public override string ToString() => $"{Name} ({ProductionYear}, {MaxSpeed} km/h)";
}