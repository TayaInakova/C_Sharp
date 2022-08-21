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

// /* Детали доработать напильником.

int[,] CreateMatrix(int x, int y)
{
    int[,] matrix = new int[x, y];
    for (int i = 0; i < matrix.GetLength(0); i++) //x
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //y
        {
            matrix[i, j] = new Random().Next(1, 5);
            Console.Write($"{matrix[i, j]} ");
        };
        Console.WriteLine();
    };
    return matrix;
};

int[,] a1 = CreateMatrix(1, 3);
Console.WriteLine();
int[,] a2 = CreateMatrix(3, 1);
Console.WriteLine();

int[,] Multiply(int[,] m1, int[,] m2)
{
    if (m1.GetLength(1) == m2.GetLength(0))
    {

        int[,] m3 = new int[m1.GetLength(0), m2.GetLength(1)];

        for (int i = 0; i < m3.GetLength(0); i++)
        {
            for (int j = 0; j < m3.GetLength(1); j++)
            {
                for (int a = 0, b = 0; a < m1.GetLength(1) && b < m2.GetLength(0); a++, b++)
                {
                    m3[i, j] += m1[i, a] * m2[b, j];
                };

                Console.Write($"{m3[i, j]} ");
            };
            Console.WriteLine();
        };
        return m3;
    }
    else
    {
        Console.WriteLine("Такие матрицы перемножать нельзя");
        int[,] a = new int[1, 1];
        return a;
    };
};
int[,] a3 = Multiply(a1, a2);

// */
