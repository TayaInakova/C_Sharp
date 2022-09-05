void SumNumbersInBetween(int result, int m, int n)
{
    result += m;
    Console.Write($"{result} ");
    if (m != n) NumbersInBetween(result, m + 1, n);
};
int sum = 0;
NumbersInBetween(sum, 1, 15);
Console.WriteLine();
int temp = 0;
NumbersInBetween(temp, 4, 8);