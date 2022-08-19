// Найти расстояние между двумя точками в пространстве по координатам

double DistanceBetweenPoints()
{
    int D()
    {
        Console.WriteLine("Введите число мерности пространства:");
        string? dd = Console.ReadLine();
        int d = Convert.ToInt32(dd);
        return d;
    };
    int space = D();
    

    int[] PointCoordinate()
    {
        string? t = Console.ReadLine();
        t = t.Replace(" ", "");
        string[] tt = t.Split(",");
        int[] u = new int[tt.Length];
        for (int i = 0; i < tt.Length; i++)
        {
            u[i] = Convert.ToInt32(tt[i]);
        };
        return u;
    };
    Console.WriteLine("Введите через запятую координаты первой точки:");

    int[] point1 = PointCoordinate();
    if (point1.Length != space)
    {
        Console.WriteLine("Число координат должно соответствовать мерности пространства, в котором находится точка. Повторите ввод:");
        point1 = PointCoordinate();
    };

    Console.WriteLine("Введите через запятую координаты второй точки:");
    
    int[] point2 = PointCoordinate();
    if (point2.Length != space)
    {
        Console.WriteLine("Число координат должно соответствовать мерности пространства, в котором находится точка. Повторите ввод:");
        point2 = PointCoordinate();
    };

    double distance = 0;
    for (int i = 0; i < space; i++)
    {
        distance += Math.Pow((point2[i] - point1[i]), 2);
    }
    distance = Math.Round(Math.Sqrt(distance), 2);
    return distance;
};

Console.WriteLine($"Расстояние между точками: {DistanceBetweenPoints()}");