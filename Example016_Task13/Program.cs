void ThirdNumber(int number)
{
    if (number < 0)
    {
        number = number * -1;
    };
    if (number < 100)
    {
        Console.WriteLine(">>> Третьей цифры нет");
    }
    else
    {
        while (number >=1000)
        {
            number = number / 10;
        }
        int thirdNum = number % 10;
     
        Console.WriteLine($">>> {thirdNum}");
    }
};

int n = new Random().Next(-10000, 10000);
Console.WriteLine(n);

ThirdNumber(n);