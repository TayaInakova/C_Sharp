// Семинар 3.
/*
Задача 1.
Сложение одномерных матриц (строка-строка)
*/

/*
int[] Arr(int[] matrix)
{
    int i = 0;
    while (i < matrix.Length)
    {
        matrix[i] = new Random().Next(1, 20);
        Console.Write($"{matrix[i]} ");
        i++;
    }
    Console.WriteLine();
    return matrix;
};

int[] s1 = new int[6];
int[] s2 = new int[6];

s1 = Arr(s1);
s2 = Arr(s2);

int[] SumMatrix(int[] m1, int[] m2)
{
    int[] m3 = new int[m1.Length];
    if (m1.Length != m2.Length)
    {
        Console.WriteLine("Матрицы должны быть однаковой размерности, замените одну или обе матрицы.");
    }
    else
    {
        for (int i = 0; i < m3.Length; i++)
        {
            m3[i] = m1[i] + m2[i];
            Console.Write($"{m3[i]} ");
        }
        Console.WriteLine();
    };
    return m3;
};
int[] s3 = SumMatrix(s1, s2);
*/

/*
Задача 2.
Умножение одномерных матриц (строка-столбец) (итог - число)
*/

/* Детали доработать напильником.

int[,] CreateMatrix(int x, int y)
{
    int[,] matrix = new int[x, y];
    for (int i = 0; i < x; i++) //x
    {
        for (int j = 0; j < y; j++) //y
        {
            matrix[i, j] = new Random().Next(1, 5);
        };
    };
    return matrix;
};

int[,] a1 = CreateMatrix(1, 3);
int[,] a2 = CreateMatrix(3, 1);

int Multiply(int[,] m1, int[,] m2)
{
    int m3 = 0;
    for (int i = 0, j = 0; i < m1.Length; i++)
    {
        m3 += m1[j, i] * m2[i, j];
    };
    Console.Write($"{m3}");
    return m3;
};
int a3 = Multiply(a1, a2);
*/

/*
Задача 3.
Умножение одномерных матриц (столбец-строка) (итог - матрица размерностью a*b)
*/

/*
...
*/
