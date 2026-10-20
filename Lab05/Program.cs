using Lab05.dictionary;
using Lab05.list;
using Lab05.matrix;

class Program
{
    static void Main()
    {
        Console.WriteLine("-------TASK 1-------");
        TestMatrix();

        Console.WriteLine("\n-------TASK 2-------");
        TestList();

        Console.WriteLine("\n-------TASK 3-------");
        TestDictionary();
    }

    static void TestMatrix()
    {
        Console.Write("rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("cols: ");
        int cols = int.Parse(Console.ReadLine());
        Console.Write("min value: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max value: ");
        int max = int.Parse(Console.ReadLine());

        MyMatrix matrix = new MyMatrix(rows, cols, min, max);
        Console.WriteLine("\nmatrix:");
        matrix.Show();

        matrix.Fill();
        Console.WriteLine("\nafter fill:");
        matrix.Show();

        matrix.ChangeSize(rows + 2, cols + 2);
        Console.WriteLine($"\nafter ChangeSize to {rows + 2}x{cols + 2}:");
        matrix.Show();

        matrix[0, 0] = 100;
        Console.WriteLine($"\nmatrix[0,0] after set: {matrix[0, 0]}");

        Console.WriteLine("\npartial view (rows 0-1, cols 0-1):");
        matrix.ShowPartialy(0, 1, 0, 1);
    }

    static void TestList()
    {
        MyList<string> list = new MyList<string> { "bmw1", "bmw2", "tesla" };
        Console.WriteLine($"count: {list.Count}");
        Console.WriteLine($"list[0]: {list[0]}");
        Console.WriteLine($"list[2]: {list[2]}");

        list.Add("lada");
        list.Add("vaz");
        Console.WriteLine($"\ncount after add: {list.Count}");
        Console.WriteLine($"list[3]: {list[3]}");

        list[0] = "mercedes";
        Console.WriteLine($"list[0] after set: {list[0]}");

        Console.WriteLine("\nforeach:");
        foreach (string item in list)
            Console.WriteLine(item);
    }

    static void TestDictionary()
    {
        MyDictionary<string, string> dict = new MyDictionary<string, string>();
        dict.Add("hello", "привет");
        dict.Add("bye", "пока");
        dict.Add("test", "тест");

        Console.WriteLine($"count: {dict.Count}");
        Console.WriteLine($"dict[\"hello\"]: {dict["hello"]}");
        Console.WriteLine($"dict[\"test\"]: {dict["test"]}");

        dict["test"] = "тестик";
        Console.WriteLine($"dict[\"test\"] after set: {dict["test"]}");

        Console.WriteLine("\nforeach:");
        foreach (KeyValuePair<string, string> pair in dict)
            Console.WriteLine($"{pair.Key} ; {pair.Value}");
    }
}