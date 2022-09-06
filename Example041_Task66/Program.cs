void SumNumbersInBetween(int result, int m, int n)
{
    result += m;
    Console.Write($"{result} ");
    if (m != n) SumNumbersInBetween(result, m + 1, n);
};
int sum = 0;
SumNumbersInBetween(sum, 1, 15);
Console.WriteLine();
int temp = 0;
SumNumbersInBetween(temp, 4, 8);