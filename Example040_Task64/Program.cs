void NumbersInBetween(int m, int n)
{
    Console.Write($"{m} ");
    if(m!=n) NumbersInBetween(m+1,n);
};

NumbersInBetween(1,5);
Console.WriteLine();
NumbersInBetween(4,8);