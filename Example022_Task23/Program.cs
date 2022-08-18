// Показать таблицу кубов числа от 1 до N. (Допустим, только целые)

void Cube(int n)
{
    Console.WriteLine(n);
    int[] num = new int[n];
    int i = 0;
    while (i < num.Length)
    {
        num[i] = (int)Math.Pow((i + 1), 3);
        Console.Write($"{num[i]} ");
        i++;
    };
};
int z = new Random().Next(1, 10);
Cube(z);
