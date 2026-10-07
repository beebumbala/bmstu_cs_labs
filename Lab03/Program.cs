using Lab03.cars;
using Lab03.currencies;
using Lab03.vectors;

class Program
{
    static void Main()
    {
        Console.WriteLine("-------TASK 1-------");
        Vector a = new Vector(1, 2, 2);
        Vector b = new Vector(2, 3, 6);
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
        Console.WriteLine("a+b: " + (a + b));
        Console.WriteLine("a*b: " + (a * b));
        Console.WriteLine("a*3: " + (a * 3));
        Console.WriteLine("3*a: " + (3 * a));
        Console.WriteLine("a==b: " + (a == b));
        Console.WriteLine("a!=b: " + (a != b));
        Console.WriteLine("a<b: " + (a < b));
        Console.WriteLine("a>=b: " + (a >= b));
        Console.WriteLine("a ? \"non-zero\" : \"zero\" -> " + (a ? "non-zero" : "zero"));

        
        Console.WriteLine("\n-------TASK 2-------");
        CarsCatalog catalog = new CarsCatalog();
        catalog.Add(new Car("bmw", "diesel", 240));
        catalog.Add(new Car("audi", "petrol", 250));
        catalog.Add(new Car("tesla", "electric", 260));

        Console.WriteLine("catalog[0]: " + catalog[0]);
        Console.WriteLine("catalog[2]: " + catalog[2]);

        Car c1 = new Car("bmw", "diesel", 240);
        Car c2 = new Car("audi", "petrol", 250);
        Console.WriteLine("ToString(c1): " + c1);
        Console.WriteLine("c1.Equals(c2): " + c1.Equals(c2));
        Console.WriteLine("c1.Equals(c0 (new in-place object equaled catalog[0])): " + c1.Equals(new Car("bmw", "diesel", 240)));

        
        Console.WriteLine("\n-------TASK 3-------");
        Console.Write("rate usd->eur: ");
        CurrencyUSD.EurRate = double.Parse(Console.ReadLine());
        Console.Write("rate usd->rub: ");
        CurrencyUSD.RubRate = double.Parse(Console.ReadLine());

        CurrencyUSD usd = new CurrencyUSD(100);
        CurrencyEUR eur = usd;
        CurrencyRUB rub = usd;
        Console.WriteLine($"usd={usd.Value:F2} eur={eur.Value:F2} rub={rub.Value:F2}");

        CurrencyRUB rub2 = eur;
        Console.WriteLine($"eur->rub: {rub2.Value:F2}");

        CurrencyUSD back = rub;
        Console.WriteLine($"rub->usd: {back.Value:F2}");
    }
}