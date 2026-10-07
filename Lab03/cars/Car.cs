namespace Lab03.cars;

public class Car : IEquatable<Car>
{
    public string Name { get; set; }
    public string Engine { get; set; }
    public double MaxSpeed { get; set; }

    public Car(string name, string engine, double maxSpeed)
    {
        Name = name;
        Engine = engine;
        MaxSpeed = maxSpeed;
    }

    public override string ToString() => Name;

    public bool Equals(Car other) =>
        other != null && Name == other.Name && Engine == other.Engine && MaxSpeed == other.MaxSpeed;

    public override bool Equals(object obj) => Equals(obj as Car);

    public override int GetHashCode() => HashCode.Combine(Name, Engine, MaxSpeed);
}