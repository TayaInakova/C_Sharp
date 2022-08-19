// Семинар 1.
/*
Задача 1.
Напишите программу, которая на вход принимает два числа
и проверяет, является ли первое квадратом второго.
*/

/*
void Square(int a, int b)
{
    int c = b * b;
    if (a == c)
    {
        Console.WriteLine($"Число {a} - квадрат числа {b}");
    }
    else
    {
        Console.WriteLine($"Число {a} - не является квадратом числа {b}");
    };
};
Square(25, 5);
*/

/*
Задача 2.
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
*/

/*
void DayOfTheWeek(int d)
{
    string[] days =
    {
    "Понедельник",
    "Вторник",
    "Среда",
    "Четверг",
    "Пятница",
    "Суббота",
    "Воскресенье"
    };
    if (d > 0 && d < 8)
    {
        Console.WriteLine($"{days[d - 1]}");
    }
    else
    {
        Console.WriteLine("Нет дня недели с таким порядковым номером");
    }
};
int a = new Random().Next(0, 10);
Console.WriteLine(a);
DayOfTheWeek(a);
*/

/*
Задача 3.
Напишите программу, которая на вход принимает число N,
а на выходе показывает все целые числа в промежутке от -N до N. 
*/

/*
void Interval(int n)
{
    Console.WriteLine(n);
    int v = (Math.Abs(n) * 2)+1;
    int[] num = new int[v];
    if (n > 0)
    {
        n *= -1;
    };
    int i = 0;
    while (i < num.Length)
    {
        num[i] = n + i;
        Console.Write($"{num[i]} ");
        i++;
    };
};
int z = new Random().Next(-10, 10);
Interval(z);
*/

/*
Задача 4.
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает последнюю цифру этого числа.
*/

/*
void Number(int a)
{
    int b = a % 10;
    Console.WriteLine(b);
};
int c = new Random().Next(100, 1000);
Console.WriteLine(c);
Number(c);
*/