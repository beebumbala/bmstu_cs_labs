namespace Lab04.matrix;

public class MyMatrix
{
    private double[,] data;

    public int Rows { get; }
    public int Cols { get; }

    public MyMatrix(int rows, int cols, int min, int max) : this(rows, cols)
    {
        Random rand = new Random();
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                data[i, j] = rand.Next(min, max + 1);
    }

    private MyMatrix(int rows, int cols)
    {
        if (rows <= 0 || cols <= 0)
            throw new Exception("rows and cols must be greater than zero");

        Rows = rows;
        Cols = cols;
        data = new double[rows, cols];
    }

    public double this[int row, int col]
    {
        get => data[row, col];
        set => data[row, col] = value;
    }

    public static MyMatrix operator +(MyMatrix a, MyMatrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new Exception("matrix sizes must be equal");

        MyMatrix result = new MyMatrix(a.Rows, a.Cols);
        for (int i = 0; i < a.Rows; i++)
            for (int j = 0; j < a.Cols; j++)
                result[i, j] = a[i, j] + b[i, j];

        return result;
    }

    public static MyMatrix operator -(MyMatrix a, MyMatrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new Exception("matrix sizes must be equal");

        MyMatrix result = new MyMatrix(a.Rows, a.Cols);
        for (int i = 0; i < a.Rows; i++)
            for (int j = 0; j < a.Cols; j++)
                result[i, j] = a[i, j] - b[i, j];

        return result;
    }

    public static MyMatrix operator *(MyMatrix a, MyMatrix b)
    {
        if (a.Cols != b.Rows)
            throw new Exception("cols of first matrix must be equal to rows of second matrix");

        MyMatrix result = new MyMatrix(a.Rows, b.Cols);
        for (int i = 0; i < a.Rows; i++)
            for (int j = 0; j < b.Cols; j++)
                for (int k = 0; k < a.Cols; k++)
                    result[i, j] += a[i, k] * b[k, j];

        return result;
    }
    public static MyMatrix operator *(MyMatrix a, double k)
    {
        MyMatrix result = new MyMatrix(a.Rows, a.Cols);
        for (int i = 0; i < a.Rows; i++)
            for (int j = 0; j < a.Cols; j++)
                result[i, j] = a[i, j] * k;

        return result;
    }
    public static MyMatrix operator *(double k, MyMatrix a) => a * k;
    public static MyMatrix operator /(MyMatrix a, double k)
    {
        if (k == 0)
            throw new Exception("dont divide by 0");

        MyMatrix result = new MyMatrix(a.Rows, a.Cols);
        for (int i = 0; i < a.Rows; i++)
            for (int j = 0; j < a.Cols; j++)
                result[i, j] = a[i, j] / k;

        return result;
    }
    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
                result += $"{data[i, j],8:F2}";
            result += "\n";
        }
        return result;
    }
}