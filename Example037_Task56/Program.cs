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

void SumInString(int[,] array)
{
    int smallerRow = 1;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int temporary = 0;
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum += array[0, j];
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            temporary += array[i, j];
        };
        if (temporary < sum)
        {
            sum = temporary;
            smallerRow = i + 1;
        }
        temporary = 0;
    };
    Console.WriteLine($"Строка с наименьшей суммой элементов: {smallerRow}"); ;
}

void Start()
{
    int[,] randomArray = new int[4, 3];
    Fill(randomArray, 1, 10);
    Print(randomArray);
    SumInString(randomArray);
}

Start();