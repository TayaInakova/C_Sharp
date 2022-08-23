double[] CreateDoubleArray(int n)
{
    return new double[n]; ;
};


void FillDoubleArray(double[] arr) //наполнение массива рандомными числами 
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
};


void PrintDoubleArray(double[] arr) // вывод массива на консоль
{
    int size = arr.Length;
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}");
        if (i<size-1)
        {
        Console.Write(", ");
        }
    };
    Console.Write("]");
    Console.WriteLine();
};

double Difference(double[] arr)
{
    double maxEl = arr[0], minEl = arr[0];
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] > maxEl)
        {
            maxEl = arr[i];
        }
        else if (arr[i] <minEl)
        {
            minEl = arr[i];
        }
    }
    double diff = maxEl - minEl;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");
return diff;
}

void Start()
{
double[] a = CreateDoubleArray(4);
FillDoubleArray(a);
PrintDoubleArray(a);
double d = Difference(a);
};

Start();