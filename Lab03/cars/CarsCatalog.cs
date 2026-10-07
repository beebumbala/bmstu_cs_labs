namespace Lab03.cars;

public class CarsCatalog
{
    private List<Car> cars = new List<Car>();

    public void Add(Car car) => cars.Add(car);

    public string this[int index] => cars[index].Name + " engine=" + cars[index].Engine;
}