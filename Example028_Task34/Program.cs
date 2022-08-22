int NumberOfEvenNumbers(int n)
{
    int[] Arr(int n)
    {
        int[] matrix = new int[n];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new Random().Next(100, 1000);
            Console.Write($"{matrix[i]} ");
        }
        Console.WriteLine();
        return matrix;
    };
    int[] b = Arr(n);
    for (int i = 0, j = 0; i < b.Length; i++)
    {
        if (b[i] % 10 == 0)
        {
            j++;
        };
    };
    return j;
};
int g = NumberOfEvenNumbers(4);