
void Arr()
{
    int[] matrix = new int[8];
    Console.Write("[");
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[i] = new Random().Next(1, 101);
        Console.Write($"{matrix[i]}");
        if (i < matrix.Length - 1)
        {
            Console.Write(",");
        };
    };
    Console.WriteLine("]");
};

Arr();