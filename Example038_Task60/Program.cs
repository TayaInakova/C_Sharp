void Fill(int[,,] array, int a, int b)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int volume = array.GetLength(2);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int z = 0; z < volume; z++)
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

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int z = 0; z < volume; z++)
            {
                Console.WriteLine($"{array[i, j, z]} ({i};{j};{z})");
            };
        };
    }
}

void Start()
{
    int[,,] tripleArray = new int[6, 3, 4];
    Fill(tripleArray, 10, 100);
    Print(tripleArray);
}

Start();