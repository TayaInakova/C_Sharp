﻿int[] array = {41,22,17,84,40,53,36,17,8};

int n = array.Length;
int find = 17;
int index = 0;
while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++;
}