
int[,] CreateArray(int m, int n)
{
    return new int[m, n]; ;
};


void FillArray(int[,] arr, int r, int f) //наполнение массива рандомными числами [r,f)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++) //x
    {
        for (int j = 0; j < columns; j++) //y
        {
            arr[i, j] = new Random().Next(r, f);
        }
    }
};


void PrintArray(int[,] arr) // вывод массива на консоль
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++) //x
    {
        for (int j = 0; j < columns; j++) //y
        {
            Console.Write($"{arr[i, j]} ");
        };
        Console.WriteLine();
    };
}

int NumberOfEvenNumbers(int[,] arr)
{
    int count = 0;
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++) //x
    {
        for (int j = 0; j < columns; j++) //y
        {
            if (arr[i, j] % 2 == 0)
            {
                count++;
            };
        };
    };
    Console.WriteLine($"В данном массиве {count} чётных элементов.");
    return count;

};

void Start()
{
    int[,] ar = CreateArray(1, 8);
    FillArray(ar, 100, 1000);
    PrintArray(ar);
    int g = NumberOfEvenNumbers(ar);
};

Start();