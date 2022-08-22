// Семинар 4.
/*
Задача 1.
Написать метод, который генерирует массив 0 и 1 заданного количества N.
*/

int[] Bin(int n)
{
    Console.Write("Случайный массив '0' и '1': ");
    int[] a = new int[n];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 2);
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
    return a;
};
int a1 = new Random().Next(1,10);
int[] firstStep = Bin(a1);

/*
Задача 2.
Написать метод, принимающий бинарное представление числа
и возвращающее десятичное представление числа.
*/

int Des(int[] b)
{
    int d = 0;
    for (int i = 0, j = b.Length - 1; i < b.Length; i++, j--)
    {
        d += Convert.ToInt32(b[i] * Math.Pow(2, j));
    };
    Console.WriteLine($"Десятичное представление заданного в двоичной системе числа: {d}");
    return d;
};
int[] umbra = { 1, 1, 0, 1, 1, 0 };
int secondStep = Des(firstStep);

/*
Задача 3.
Написать метод, принимающий десятичное представление числа
и основание системы счисления, в которую нужно это число перевести
(2 <= основание <= 9)
*/

int Transfer(int c, int e)
{
    int g = 0;
    if (c != 0)
    {
        string f = string.Empty;
        string ff = string.Empty;
        int temporary = 0;
        for (int i = 0; c > 0; i++)
        {
            temporary = c % e;
            c = c / e;
            f += Convert.ToString(temporary);
        };
        for (int i = 0, j = 1; i < f.Length; i++, j++)
        {
            ff += f[f.Length - j];
        };
        g = Convert.ToInt32(ff);
        Console.WriteLine($"{e}-чное представление заданного числа: {g}");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Перевод нуля в любую систему счисления даст ноль.");
    };
    return g;
};
int r = new Random().Next(2, 10);
int ThirdStep = Transfer(secondStep, r);

