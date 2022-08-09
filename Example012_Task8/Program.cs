void EvenToN(double N)
{
    int i = 1;
    string mass = (">>> ");

    while (i < N)
    {
        int ost = i % 2;
        if (ost == 0)
        {
            mass += $" {i}";
        }
        i++;
    };
    Console.WriteLine(mass);};


EvenToN(10.5);
EvenToN(14);