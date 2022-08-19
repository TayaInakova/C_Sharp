double DistanceBetweenPoints(int[] firstN, int[] secondN)
{
    void Point(int[] point)
    {
        void FillArray(int[] arr)

        {
            int i = 0;
            while (i < arr.Length)
            {
                arr[i] = new Random().Next(1, 20);
                i++;
            }
        };
        void PrintArray(int[] array)
        {
            int j = 0;
            while (j < array.Length)
            {
                Console.Write($"{array[j]} ");
                j++;
            }
        };

        FillArray(point);
        PrintArray(point);
        Console.WriteLine();
    };

    Console.WriteLine("Даны координаты первой точки:");
    Point(firstN);

    Console.WriteLine("Даны координаты второй точки:");
    Point(secondN);

    double dis = Math.Round(Math.Sqrt(Math.Pow((secondN[0] - firstN[0]), 2) + Math.Pow((secondN[1] - firstN[1]), 2) + Math.Pow((secondN[2] - firstN[2]), 2)), 2);
    Console.WriteLine($"Расстояние между точками: {dis}");
    return dis;
};

int[] a = new int[3];
int[] b = new int[3];

double distance = DistanceBetweenPoints(a, b);