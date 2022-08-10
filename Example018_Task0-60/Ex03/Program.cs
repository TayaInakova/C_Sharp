void Сcompare(int a, int b)
{
    int c = a / b;
    if (c == b)
    {
        Console.WriteLine($">>> Число {a} является квадратом числа {b}");
    }
    else
    {
        Console.WriteLine($">>> Число {a} не является квадратом числа {b}");
    };
};
