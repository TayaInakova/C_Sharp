// Показать числа от -N до N. (Допустим, только целые)

void Interval(int n)
{
    Console.WriteLine(n);
    int v = (Math.Abs(n) * 2)+1;
    Console.WriteLine(v);
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
