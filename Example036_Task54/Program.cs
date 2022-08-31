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

int[,] SortArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int temporary = array[0, 0];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = j + 1; k < columns; k++)
            {
                if (array[i, k] > array[i, j])
                {
                    temporary = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temporary;
                };
            };
        };
    };
    return array;
}

void Start()
{
    int[,] originalArray = CreateRandomArray(5);
    Fill(originalArray,1,10);
    Print(originalArray);
    Console.WriteLine();
    int[,] convertedArray = SortArray(originalArray);
    Print(convertedArray);
}

Start();