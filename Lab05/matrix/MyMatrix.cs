namespace Lab05.matrix;

public class MyMatrix
{
    private double[,] data;
    private Random rand = new Random();
    private int min;
    private int max;

    public int Rows { get; private set; }
    public int Cols { get; private set; }

    public MyMatrix(int rows, int cols, int min, int max)
    {
        if (rows <= 0 || cols <= 0)
            throw new Exception("rows and cols must be greater than zero");
        if (min > max)
            throw new Exception("min must be less than or equal to max");

        Rows = rows;
        Cols = cols;
        this.min = min;
        this.max = max;
        data = new double[rows, cols];
        Fill();
    }

    public double this[int row, int col]
    {
        get
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Cols)
                throw new Exception("index out of bounds");
            return data[row, col];
        }
        set
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Cols)
                throw new Exception("index out of bounds");
            data[row, col] = value;
        }
    }

    public void Fill()
    {
        for (int i = 0; i < Rows; i++)
            for (int j = 0; j < Cols; j++)
                data[i, j] = rand.Next(min, max + 1);
    }

    public void ChangeSize(int newRows, int newCols)
    {
        if (newRows <= 0 || newCols <= 0)
            throw new Exception("rows and cols must be greater than zero.");

        double[,] newData = new double[newRows, newCols];
        for (int i = 0; i < newRows; i++)
            for (int j = 0; j < newCols; j++)
            {
                if (i < Rows && j < Cols)
                    newData[i, j] = data[i, j];
                else
                    newData[i, j] = rand.Next(min, max + 1);
            }

        Rows = newRows;
        Cols = newCols;
        data = newData;
    }

    public void ShowPartialy(int startRow, int endRow, int startCol, int endCol)
    {
        if (startRow < 0 || endRow >= Rows || startCol < 0 || endCol >= Cols || startRow > endRow || startCol > endCol)
            throw new Exception("invalid bounds");

        for (int i = startRow; i <= endRow; i++)
        {
            for (int j = startCol; j <= endCol; j++)
                Console.Write($"{data[i, j],5}");
            Console.WriteLine();
        }
    }

    public void Show() => ShowPartialy(0, Rows - 1, 0, Cols - 1);
}