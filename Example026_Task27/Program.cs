int SumMembers(int a)
{
    Console.WriteLine(a);
    int b = 0;
    for (int i = 0; a > 0; i++)
    {
        b += a % 10;
        a = a / 10;
    };
    Console.WriteLine(b);
    return b;
};

int n = new Random().Next(100, 1000);
int m = SumMembers(n);