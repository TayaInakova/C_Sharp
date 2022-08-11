void ThirdNumber(string number)
{
     char[] thirdNum = number.ToCharArray();
     
        Console.WriteLine($">>> {thirdNum[2]}");
    };

string n = "2645689";
Console.WriteLine(n);

ThirdNumber(n);
