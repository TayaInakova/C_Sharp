// В задаче требуется найти элемент по позиции, но пример выглядит так, будто ищется определённое значение. На всякий случай прилагаю оба решения.

// поиск элемента по позиции:

void Fill(int[,] array, int a, int b)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(a, b);
        }
    }
};


void Print(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} ");
        };
        Console.WriteLine();
    };
}

int FindByLocation(int[,] array, int x, int y)
{
    int numberByLocation = 0;
    if (x > 0 && x < array.GetLength(0) && y > 0 && y < array.GetLength(1))
    {
        numberByLocation = array[x - 1, y - 1];
        Console.WriteLine(numberByLocation);
    }
    else
    {
        Console.WriteLine("Нет элемента на данной позиции");
    }
    return numberByLocation;
}

void Start00()
{
    int width = new Random().Next(5, 15);
    int length = new Random().Next(5, 15);
    int[,] table = new int[width, length];
    Fill(table, 1, 100);
    Print(table);
    int widthPosition = new Random().Next(1, 10);
    int lengthPosition = new Random().Next(1, 10);
    Console.Write($"Элемент на позиции [{lengthPosition};{widthPosition}]: "); // по принципу lengthPosition вправо, widthPosition вниз
    FindByLocation(table, widthPosition, lengthPosition);
}

Start00();
Console.WriteLine();

// Поиск конкретного значения в мвссиве:

void SearchByValue(int[,] array, int value)
{
    Console.Write($"Поиск числа {value}: ");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i, j] == value)
            {
                Console.WriteLine($"число находится на позиции [{i};{j}]");
                count++;
                break;
            }
            if (count != 0) break;
        }
    }
    if (count == 0) Console.WriteLine("Искомого числа нет в массиве");
}

void Start01()
{
    int width = new Random().Next(5, 15);
    int length = new Random().Next(5, 15);
    int[,] table = new int[width, length];
    Fill(table, 1, 100);
    Print(table);
    int randomvalue = new Random().Next(1, 101);
    SearchByValue(table, randomvalue);
}

Start01();