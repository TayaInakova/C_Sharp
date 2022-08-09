void Two(int a)
{
    int num = (a / 10) % 10;
    Console.WriteLine(num);
};

int v = new Random().Next(100, 1000);
Console.WriteLine(v);

Two(v);