void Exponentiation(int a, int b)
{

    Console.WriteLine($"Число {a} возводим в степень {b}.");
    int c = 1;
    for (int i = 0; i < b; i++)
    {
        c *= a;
    }
    Console.WriteLine($"Итог: {c}.");
};
int d = new Random().Next(1, 10);
int e = new Random().Next(1, 10);

Exponentiation(d, e);