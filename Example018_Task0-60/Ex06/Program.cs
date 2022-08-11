// Выяснить является ли число чётным.

void Even(int a)
{
    int b = a % 2;
    if (b == 0)
    {
       Console.WriteLine($"{a} - чётное");
    }
    else
    {
       Console.WriteLine($"{a} - нечётное");
    }
};

int z = new Random().Next(1, 100);
Even(z);