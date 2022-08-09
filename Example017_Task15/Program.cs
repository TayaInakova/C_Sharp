void Day(int d)
{
string[] days =
{
    "рабочий день",
    "рабочий день",
    "рабочий день",
    "рабочий день",
    "рабочий день",
    "выходной день",
    "выходной день"
};
if (d > 0 && d < 8)
{ 
Console.WriteLine($"{days[d-1]}");
}
else
{
    Console.WriteLine("Нет дня недели с таким порядковым номером");
}
};

int a = new Random().Next(0, 10);
Console.WriteLine(a);
Day(a);