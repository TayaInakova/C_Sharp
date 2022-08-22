double[] CreateDoubleArray(int n)
{
    return new double[n]; ;
};


void FillDoubleArray(double[] arr) //наполнение массива рандомными числами 
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1,10);
    }
};


void PrintDoubleArray(double[] arr) // вывод массива на консоль
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    };
    Console.WriteLine();
};
double[] a = CreateDoubleArray(4);
FillDoubleArray(a);
PrintDoubleArray(a);
