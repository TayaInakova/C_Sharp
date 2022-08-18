double DistanceBetweenPoints()
{
    void Point(int[] point)
    {
        void FillArray(int[] arr)

        {
            int length = arr.Length;
            int i = 0;
            while (i < length)
            {
                arr[i] = new Random().Next(1, 20);
                i++;
            }
        };
        void PrintArray(int[] array)
        {
            int count = array.Length;
            int j = 0;
            while (j < count)
            {
                Console.Write($"{array[j]} ");
                j++;
            }
            Console.WriteLine();
        };

        FillArray(point);
        PrintArray(point);
        Console.WriteLine();
    };
    int[] firstN = new int[3];
    int[] secondN = new int[3];

    Console.WriteLine("Даны координаты первой точки:");
    Point(firstN);

    Console.WriteLine("Даны координаты второй точки:");
    Point(secondN);

    double dis = Math.Sqrt(Math.Pow((secondN[0] - firstN[0]), 2) + Math.Pow((secondN[1] - firstN[1]), 2) + Math.Pow((secondN[2] - firstN[2]), 2));
    Console.WriteLine($"Расстояние между точками: {dis}");
    return dis;
};

DistanceBetweenPoints();