
int[] InitializingVariables()
{
    string? userTextData = Console.ReadLine();
    userTextData = userTextData!.Replace(" ", "");
    userTextData = userTextData!.Replace(".", "");
    userTextData = userTextData!.Replace(";", "");
    userTextData = userTextData!.Replace("/", "");
    string[]? userTextDataArray = userTextData.Split(",");
    int[] userIntDataArray = new int[userTextDataArray.Length];
    for (int i = 0; i < userTextDataArray.Length; i++)
    {
        userIntDataArray[i] = Convert.ToInt32(userTextDataArray[i]);
    };
    return userIntDataArray;
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
    Console.WriteLine("Даны две прямые, заданные уравнениями y=k1*x+b1 и y=k2*x+b2."); // Приведём их к виду k1*x + с*y = -b1 и k2*x + с*y = -b2
    Console.WriteLine("Введите через запятую последовательно значения переменных k1, b1, k2, b2:");
    int[] numbers = InitializingVariables();
    int c1 = -1, c2 = -1;
    int k1 = numbers[0];
    int b1 = numbers[1];
    int k2 = numbers[2];
    int b2 = numbers[3];
    int[,] d = new int[2, 2];
    int[,] dx = new int[2, 2];
    int[,] dy = new int[2, 2];
    Fill(d, k1, c1, k2, c2);
    Fill(dx, -1 * b1, c1, -1 * b2, c2);
    Fill(dy, k1, -1 * b1, k2, -1 * b2);
    int dGeneral = Determinant(d);
    if (dGeneral != 0)
    {
        double dOfx = Determinant(dx);
        double dOfy = Determinant(dy);
        double x = Math.Round((dOfx / dGeneral), 2);
        double y = Math.Round((dOfy / dGeneral), 2);
        Console.WriteLine($"Точка пересечения заданных прямых имеет координаты: [{x};{y}]");
    }
    else
    {
        Console.WriteLine("Точки пересечения нет.");
    }
}
Start();