using Lab02.pupils;
using Lab02.vehicles;
using Lab02.documentaries;

class Program
{
    static void Main()
    {
        Console.WriteLine("-------TASK 1-------");
        ClassRoom room = new ClassRoom(new ExcellentPupil(), new GoodPupil(), new BadPupil());
        room.Show();

        Console.WriteLine("\n-------TASK 2-------");
        Vehicle[] vehicles =
        {
            new Plane(10, 20, 1000000, 900, 2020, 10000, 300),
            new Car(0, 0, 20000, 200, 2022),
            new Ship(5, 5, 500000, 60, 2019, 500, "Sochi")
        };
        foreach (var v in vehicles)
            v.Info();

        Console.WriteLine("\n-------TASK 3-------");
        Console.Write("key: ");
        
        string? key = Console.ReadLine();

        DocumentWorker worker;
        switch (key)
        {
            case "pro":
                Console.WriteLine("you are using pro version");
                worker = new ProDocumentWorker();
                break;
            case "exp":
                Console.WriteLine("you are using expert version");
                worker = new ExpertDocumentWorker();
                break;
            default:
                Console.WriteLine("you are using default version");
                worker = new DocumentWorker();
                break;
        }

        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();
    }
}