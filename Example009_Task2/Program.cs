int number1 = new Random().Next(1,10);
int number2 = new Random().Next(1,10);
Console.WriteLine(number1);
Console.WriteLine(number2);

if (number1 > number2)
{
    Console.Write("max = ");
    Console.WriteLine(number1);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(number2);
}