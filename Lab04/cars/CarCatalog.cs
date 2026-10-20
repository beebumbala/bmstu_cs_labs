using System.Collections;

namespace Lab04.cars;

public class CarCatalog : IEnumerable<Car>
{
    private List<Car> cars = new List<Car>();

    public void Add(Car car) => cars.Add(car);

    public IEnumerator<Car> GetEnumerator()
    {
        foreach (Car car in cars)
            yield return car;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerable<Car> GetReverse()
    {
        for (int i = cars.Count - 1; i >= 0; i--)
            yield return cars[i];
    }

    public IEnumerable<Car> FilterByYear(int minYear)
    {
        foreach (Car car in cars)
            if (car.ProductionYear >= minYear)
                yield return car;
    }

    public IEnumerable<Car> FilterBySpeed(double minSpeed)
    {
        foreach (Car car in cars)
            if (car.MaxSpeed >= minSpeed)
                yield return car;
    }
}