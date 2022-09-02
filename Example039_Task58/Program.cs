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
            array[i, j] = new Random().Next(a, b);
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

int[,] Multiply(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);

    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);

    int[,] resultMatrix = new int[rows1, columns2];

    int rowsResultMatrix = resultMatrix.GetLength(0);
    int columnsResultMatrix = resultMatrix.GetLength(1);

    if (columns1 == rows2)
    {
        for (int i = 0; i < rowsResultMatrix; i++)
        {
            for (int j = 0; j < columnsResultMatrix; j++)
            {
                for (int a = 0, b = 0; a < columns1 && b < rows2; a++, b++)
                {
                    resultMatrix[i, j] += matrix1[i, a] * matrix2[b, j];
                };

                Console.Write($"{resultMatrix[i, j]} ");
            };
            Console.WriteLine();
        };
    }
    else
    {
        Console.WriteLine("Такие матрицы перемножать нельзя");
    };
    return resultMatrix;
};

void Start()
{
    int[,] firstMatrix = CreateRandomArray(5);
    int[,] secondMatrix = CreateRandomArray(5);
    Fill(firstMatrix, 1, 10);
    Fill(secondMatrix, 1, 10);
    Print(firstMatrix);
    Console.WriteLine();
    Print(secondMatrix);
    Console.WriteLine();
    int[,] multiplication = Multiply(firstMatrix, secondMatrix);
};

Start();