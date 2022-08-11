//Даны два числа. Показать большее и меньшее число.

void Comparison(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine($">>> {a} - большее число, {b} - меньшее число");
    }
    else
    {
        Console.WriteLine($">>> {b} - большее число, {a} - меньшее число");
    }
};

int s = new Random().Next(1,1000);
int r = new Random().Next(1,1000);
Console.WriteLine(s);
Console.WriteLine(r);


Comparison(s, r);
