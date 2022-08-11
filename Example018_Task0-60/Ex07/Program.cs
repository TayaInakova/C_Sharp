// Показать числа от -N до N. (Допустим, только целые)

void Interval(int n)
{
    int v = (n * 2)+1;
    int[] num = new int[v];
    int i = 0, y = 0;
    while (i < num.Length)
    {
        num[i] = n - y;
        i++;
        y++;
    };
    Console.WriteLine($">>> {num}");

};

int z = new Random().Next(1, 10);
Interval(z);