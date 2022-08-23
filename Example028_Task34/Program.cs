
int[] CreateArray(int n)
{
    return new int[n]; ;
};


void FillArray(int[] arr, int r, int f) //наполнение массива рандомными числами [r,f)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(r, f);
    }
};


void PrintArray(int[] arr) // вывод массива на консоль
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    };
    Console.WriteLine();
};

int NumberOfEvenNumbers(int[] arr)
{
    int count = 0;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        };
    };
    Console.WriteLine($"Количество чётных элементов: {count}");
    return count;

};

void Start()
{
    int[] ar = CreateArray(8);
    FillArray(ar, 100, 1000);
    PrintArray(ar);
    int g = NumberOfEvenNumbers(ar);
};

Start();