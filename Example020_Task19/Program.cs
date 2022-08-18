void Palindrome(int p)
{
    Console.WriteLine(p);

    int k = 0, i = 0, j = 0, r = 0, c = p;

    while (c > 0)
    {
        c /= 10;
        k++;
    };

    int[] pal = new int[k];
    int[] pal1 = new int[k];

    for (i = 0; i < pal.Length; i++)
    {
        pal[i] = p % 10;
        p = p / 10;
    };

    for (i = 0, j = 1; i < pal.Length; i++, j++)
    {
        pal1[i] = pal[pal.Length - j];
    };

    for (i = 0, r = 0; i < pal.Length; i++)
    {
        if (pal[i] == pal1[i])
        {
            r++;
        };
    };

    if (r == pal.Length)
    {
        Console.WriteLine("Данное число - палиндром");
    }
    else
    {
        Console.WriteLine("Данное число - не палиндром");
    };

};
int a = 125521;
int b = 123456;
Palindrome(a);
Palindrome(b);