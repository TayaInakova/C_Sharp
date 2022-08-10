void Sqr(int a, int b)
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

int q = new Random().Next(1,1000);
int z = new Random().Next(1,1000);
Console.WriteLine(q);
Console.WriteLine(z);

Sqr(q, z);

int n1 = 25;
int n2 = 5;
Console.WriteLine(n1);
Console.WriteLine(n2);

Sqr(n1, n2);