void ThirdNumber(int number)
{
    if (number < 0)
    {
        number *= -1;
    }
    string num = Convert.ToString(number);
    char[] thirdNum = num.ToCharArray();
    if (thirdNum.Length < 3)
    {
         Console.WriteLine($">>> Заданное число не имеет третьей цифры");
    }
    else
    {
        Console.WriteLine($">>> {thirdNum[2]}");
    };
};

int n = new Random().Next(-1000, 1000);
Console.WriteLine(n);

ThirdNumber(n);
