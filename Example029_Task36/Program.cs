
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

int SumElements(int[] arr)
{
    int sumEl = 0;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0)
        {
            sumEl += arr[i];
        }
    };
    Console.WriteLine(sumEl);
    return sumEl;
}


void Start()
{
    int[] a = CreateArray(8);
    FillArray(a, 1, 100);
    PrintArray(a);
    int b = SumElements(a);
}

Start();