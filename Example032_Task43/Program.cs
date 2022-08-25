
int, int, int, int InitializingVariables(int a, int b, int c, int d)
{
    string? userTextData = Console.ReadLine();
    userTextData = userTextData!.Replace(" ", "");
    userTextData = userTextData!.Replace(".", "");
    userTextData = userTextData!.Replace(";", "");
    userTextData = userTextData!.Replace("/", "");
    string[]? userTextDataArray = userTextData.Split(",");
    a = Convert.ToInt32(userTextDataArray[0]);
    b = Convert.ToInt32(userTextDataArray[1]);
    c = Convert.ToInt32(userTextDataArray[2]);
    d = Convert.ToInt32(userTextDataArray[3]);
    return (a, b, c, d);
};

void Fill(int[,] array, int a, int b, int c, int d) //наполнение матрицы данными
{
    array[0, 0] = a;
    array[0, 1] = b;
    array[1, 0] = c;
    array[1, 1] = d;
};

int Determinant(int[,] array)
{
    int determinant = (array[0, 0] * array[1, 1]) - (array[0, 1] * array[1, 0]);
    return determinant;
}

void Start()
{
    Console.WriteLine("Даны две прямые, заданные уравнениями y=k1*x+b1 и y=k2*x+b2."); // Приведём их к виду k1*x + с*y= -b1 и k2*x +с*y= -b2
    Console.WriteLine("Введите через запятую последовательно значения переменных k1, b1, k2, b2:");
    int k1 = 0, k2 = 0, b1 = 0, b2 = 0;
    int c1 = -1, c2 = -1;
    InitializingVariables(k1, b1, k2, b2);
    System.Console.WriteLine($"{k1},{k2},{b1},{b2}");
    int[,] d = new int[2, 2];
    int[,] dx = new int[2, 2];
    int[,] dy = new int[2, 2];
    Fill(d, k1, c1, k2, c2);
    Fill(dx, -b1, c1, -b2, c2);
    Fill(dy, k1, b1, k2, b2);
    int dGeneral = Determinant(d);
    if (dGeneral != 0)
    {
        int dOfx = Determinant(dx);
        int dOfy = Determinant(dy);
        int x = dOfx / dGeneral;
        int y = dOfy / dGeneral;
        Console.WriteLine("Точка пересечения заданных прямых имеет координаты: [{x},{y}]");
    }
    else
    {
        Console.WriteLine("Точки пересечения нет.");
    }
}
Start();