int[,] CreateRandomArray(int a)
{
    int width = new Random().Next(1, a + 1);
    int length = new Random().Next(1, a + 1);
    int[,] array = new int[width, length];
    return array;
}


void Fill(int[,] array, int a, int b)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(a, b + 1);
        }
    }
};


void Print(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} ");
        };
        Console.WriteLine();
    };
}


double[] ArithmeticMeanOfTheColumn(int[,] array)
{
    int sum = 0;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] arithmeticMean = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        };
        double volue = Convert.ToDouble(sum);
        arithmeticMean[j] = Math.Round(volue / rows,1);
        Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {arithmeticMean[j]}");
        sum = 0;
    };
    return arithmeticMean;
}

void Start()
{
    int[,] spreadsheet = CreateRandomArray(5);
    Fill(spreadsheet, 1, 100);
    Print(spreadsheet);
    double[] sequence = ArithmeticMeanOfTheColumn(spreadsheet);
}
Start();