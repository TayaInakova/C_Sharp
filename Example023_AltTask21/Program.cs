// Найти расстояние между двумя точками в пространстве по координатам

int D()
{
    Console.WriteLine("Введите число мерности пространства:");
    int d = Convert.ToInt32(Console.ReadLine());
    return d;
};

int[] PointCoordinate()
{
    Console.WriteLine("Ведите координаты через запятую:");
    string? t = Console.ReadLine();
    t = t!.Replace(" ", "");
    t = t!.Replace(".", "");
    t = t!.Replace(";", "");
    t = t!.Replace("/", "");
    string[]? tt = t.Split(",");
    int[] u = new int[tt.Length];
    for (int i = 0; i < tt.Length; i++)
    {
        u[i] = Convert.ToInt32(tt[i]);
    };
    return u;
};

double DistanceBetweenPoints()
{
    int space = D();
    Console.WriteLine("Для первой точки:");
    int[] point1 = PointCoordinate();
    while (point1.Length != space)
    {
        Console.WriteLine("Число координат должно соответствовать мерности пространства, в котором находится точка. Повторите ввод:");
        point1 = PointCoordinate();
    };

    Console.WriteLine("Для второй точки:");
    int[] point2 = PointCoordinate();
    while (point2.Length != space)
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