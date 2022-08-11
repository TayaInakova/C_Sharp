// Найти максимальное из трех чисел.

void Max(int a, int b, int c)
{
    int[] numbers = {a, b, c};
Console.WriteLine($"Даны числа: {numbers[0]}, {numbers[1]}, {numbers[2]}");
int i=0;
int max=numbers[0];

while (i<numbers.Length)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    };
    i++;
};

    Console.Write("max = ");
    Console.WriteLine(max);
};

int d = new Random().Next(1,1000);
int e = new Random().Next(1,1000);
int f = new Random().Next(1,1000);



Max(d, e, f);
