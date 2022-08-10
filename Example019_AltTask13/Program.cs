void ThirdNumber(string number)
{
     char[] thirdNum = number.ToCharArray();
     
        Console.WriteLine($">>> {thirdNum[2]}");
    };

int n = new Random().Next(-10000, 10000);
n = Convert.ToString(n);
Console.WriteLine(n);

ThirdNumber(n);
