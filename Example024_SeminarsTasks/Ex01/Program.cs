// Семинар 2.
/*
Задача 1.
Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого числа.
*/

/*
void Ran()
{
    int n = new Random().Next(100,1000);
    Console.WriteLine(n);
    string nn = Convert.ToString(n);
    Console.WriteLine($"{nn[0]}{nn[2]}");
};
Ran();
*/

/*
Задача 2.
Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе чисто кратным первому. Если нет, то выводит остаток от деления.
*/

/*
int Divisible(int a, int b)
{
    int c = b % a;
    if (c == 0)
    {
        Console.WriteLine($"Число {b} крато числу {a}.");
    }
    else
    {
        Console.WriteLine($"Число {b} не крато числу {a}. Остаток от деления - {c}");
    }
    return c;
};
int u = new Random().Next(1, 10);
int r = new Random().Next(1, 100);

int v = Divisible(u, r);
*/

/*
Задача 3.
Напишите программу, которая принимает на вход число
и проверяет, кратно ли оно одновременно 7 и 23
*/

/*
void DoubleDivisible(int a)
{
    int b = a % 7;
    int c = a % 23;
    if (b == 0 && c == 0)
    {
        Console.WriteLine($"Число {a} кратно 7 и 23 одновременно.");
    }
    else
    {

        Console.WriteLine($"Число {a} не кратно 7 и 23.");
    };
};
int f = new Random().Next(1, 1000);
DoubleDivisible(f);
*/

/*
Задача 4.
Напишите программу, которая принимает на вход два числа
и проверяет, является ли одно число квадратом второго.
*/

/*
void Sq(int a, int b)
{
    if (a == Math.Pow(b, 2))
    {
        Console.WriteLine($"Число {a} квадрат числа {b}.");
    }
    else if (b == Math.Pow(a, 2))
    {
        Console.WriteLine($"Число {b} квадрат числа {a}.");
    }
    else
    {
        Console.WriteLine($"Ни одно из чисел не квадрат другого.");
    }
};
int e = new Random().Next(1, 100);
int m = new Random().Next(1, 100);
Sq(e, m);
*/
