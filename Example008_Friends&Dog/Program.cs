﻿int i=0; // Счётчик пробежек Тузика
double d=10000; // Дистанция
double ffs=1; // Скорость первого камрада
double sfs=2; // Скорость второго камрада
double ds=5; // Скорость Тузика
int f=2; // В сторону какого камрада бежит Тузик
double t=0; // Время, потребное Тузику, чтобы добежать до нужного камрада

while (d>1)
{
    if(f==1)
    {
        t=d/(ffs*ds);
        f=2;
    }
    else
    {
        t=d/(sfs*ds);
        f=1;
    }
    d-=(ffs+sfs)*t;
    i++;
}
Console.Write("Тузик пробежался ");
Console.Write(i);
Console.Write(" раз.");
