void EvenA(int n)
{
    string num = string.Empty;
    int j = 1;
    while (j <= n)
    {
        if (j % 2 == 0)
        {
            num += $"{j} ";
            j++;
        }
        else
        {
            j++;
        };
    };
    Console.WriteLine(num);
};
int z = new Random().Next(1, 10);
Console.WriteLine(z);
EvenA(z);
