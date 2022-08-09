void Even(int a)
{
    int b = a % 2;
    if (b == 0)
    {
       Console.WriteLine($"{a}" + " - чётное");
    }
    else
    {
       Console.WriteLine($"{a}" + " - нечётное");
    }
};
int v=4;
int h=7;
Even(v);
Console.WriteLine();
Even(-3);
Console.WriteLine();
Even(h);

