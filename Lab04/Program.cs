using Lab04.cars;
using Lab04.matrix;


class Program
{
    static void Main()
    {
        Console.WriteLine("-------TASK 1-------");
        TestMatrix();

        Console.WriteLine("\n-------TASK 2-------");
        TestSorting();

        Console.WriteLine("\n-------TASK 3-------");
        TestCatalog();
    }

    static void TestMatrix()
    {
        Console.Write("\nrows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("cols: ");
        int cols = int.Parse(Console.ReadLine());
        Console.Write("min value: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max value: ");
        int max = int.Parse(Console.ReadLine());

        MyMatrix a = new MyMatrix(rows, cols, min, max);
        MyMatrix b = new MyMatrix(rows, cols, min, max);

        Console.WriteLine($"\nmatrix a:\n{a}");
        Console.WriteLine($"matrix b:\n{b}");
        Console.WriteLine($"a+b:\n{a + b}");
        Console.WriteLine($"a-b:\n{a - b}");
        
        MyMatrix c = new MyMatrix(cols, rows, min, max);
        Console.WriteLine($"a*c:\n{a * c}");
        
        Console.WriteLine($"a*2:\n{a * 2}");
        Console.WriteLine($"2*a:\n{2 * a}");
        Console.WriteLine($"a/2:\n{a / 2}");

        Console.WriteLine($"a[0,0]: {a[0, 0]}");
        a[0, 0] = 100;
        Console.WriteLine($"a[0,0] after change: {a[0, 0]}");
    }

    static void TestSorting()
    {
        Car[] cars =
        {
            new Car("bmw1", 2025, 3000),
            new Car("bmw2", 2022, 250),
            new Car("lada", 1850, 50)
        };

        Console.WriteLine("initial:");
        PrintCars(cars);

        Array.Sort(cars, new CarComparer(CarComparer.SortField.Name));
        Console.WriteLine("\nsorted by name:");
        PrintCars(cars);

        Array.Sort(cars, new CarComparer(CarComparer.SortField.ProductionYear));
        Console.WriteLine("\nsorted by year:");
        PrintCars(cars);

        Array.Sort(cars, new CarComparer(CarComparer.SortField.MaxSpeed));
        Console.WriteLine("\nsorted by max speed:");
        PrintCars(cars);
    }

    static void PrintCars(Car[] cars)
    {
        foreach (Car car in cars)
            Console.WriteLine(car);
    }

    static void TestCatalog()
    {
        CarCatalog catalog = new CarCatalog();
        catalog.Add(new Car("bmw1", 2025, 3000));
        catalog.Add(new Car("bmw2", 2022, 250));
        catalog.Add(new Car("lada", 1850, 50));

        Console.WriteLine("initial:");
        foreach (Car car in catalog)
            Console.WriteLine(car);

        Console.WriteLine("\nreverse:");
        foreach (Car car in catalog.GetReverse())
            Console.WriteLine(car);

        Console.Write("\nmin production year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine($"cars with year >= {year}:");
        foreach (Car car in catalog.FilterByYear(year))
            Console.WriteLine(car);

        Console.Write("\nmin speed: ");
        double speed = double.Parse(Console.ReadLine());
        Console.WriteLine($"cars with max speed >= {speed}:");
        foreach (Car car in catalog.FilterBySpeed(speed))
            Console.WriteLine(car);
    }
}