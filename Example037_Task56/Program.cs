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

int[,] SumInString(int[,] array)
{
    int sum = 0;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int temporary = array[0, 0];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           sum += array[i,j];
        };
    };
    return array;
}

void Start()
{
    int[,] originalArray = new int[5,8];
    Fill(originalArray,1,10);
    Print(originalArray);
    SumInString(originalArray);
}

Start();