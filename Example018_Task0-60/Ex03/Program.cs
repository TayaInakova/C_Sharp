// По заданному номеру дня недели вывести его название.

void DayOfTheWeek(int d)
{
string[] days =
{
    "Понедельник",
    "Вторник",
    "Среда",
    "Четверг",
    "Пятница",
    "Суббота",
    "Воскресенье"
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
DayOfTheWeek(a);