void FillDifferentValues(int[,,] array, int a, int b)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int volume = array.GetLength(2);

    for (int z = 0; z < volume; z++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j, z] = new Random().Next(a, b);
            }
        }
    }
};

void Print(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int volume = array.GetLength(2);

    for (int z = 0; z < volume; z++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"{array[i, j, z]} ({i};{j};{z})");
            };
        };
    }
}

void Start()
{
    int[,,] tripleArray = new int[2, 2, 2];
    FillDifferentValues(tripleArray, 10, 100);
    Print(tripleArray);
}

Start();