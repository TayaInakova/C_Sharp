int[] numbers = {78, 4, 56};
Console.WriteLine($"Даны числа: {numbers[0]}, {numbers[1]}, {numbers[2]}");
int i=0;
int max=numbers[0];

while (i<numbers.Length)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    };
    i++;
};

    Console.Write("max = ");
    Console.WriteLine(max);
