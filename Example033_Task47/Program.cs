double[,] CreateArray(int m, int n)
{
    return new double[m, n]; ;
};

void FillDoubleArray(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }
};

void PrintArray(double[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{arr[i, j]} ");
        };
        Console.WriteLine();
    };
}

void Start()
{
    double[,] y = CreateArray(3, 4);
    FillDoubleArray(y);
    PrintArray(y);
};

Start();