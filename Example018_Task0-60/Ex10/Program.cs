void Number(int a)
{
    int b = a / 10;
    b = b % 10;
    Console.WriteLine(b);
};
int c = new Random().Next(100, 1000);
Console.WriteLine(c);
Number(c);