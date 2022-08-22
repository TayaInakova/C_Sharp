// Семинар 6.

int[,] CreateMatrix(int m, int n) //создание массива определенной размерности
{
    return new int[m, n]; ;
};


void Fill(int[,] matrix, int r, int f) //наполнение массива рандомными числами [r,f)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++) //x
    {
        for (int j = 0; j < columns; j++) //y
        {
            matrix[i, j] = new Random().Next(r, f);
        }
    }
};


void Print(int[,] matrix) // вывод массива на консоль
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++) //x
    {
        for (int j = 0; j < columns; j++) //y
        {
            Console.Write($"{matrix[i, j]} ");
        };
        Console.WriteLine();
    };
}

void Task01() // решение задачи 1
{
    int[,] u = CreateMatrix(3, 4);
    Fill(u, 1, 10);
    Print(u);
}
//Task01();

// 2.
double[,] CreateMass(int m, int n) //создание массива определенной размерности
{
    return new double[m, n]; ;
};

void FillDoubleMass(double[,] matrix)  //наполнение массива рандомными вещественными числами [r,f)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++) //x
    {
        for (int j = 0; j < columns; j++) //y
        {
            matrix[i, j] = Math.Round(new Random().NextDouble(), 2);
        }
    }
};

void PrintMass(double[,] matrix) // вывод массива на консоль
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++) //x
    {
        for (int j = 0; j < columns; j++) //y
        {
            Console.Write($"{matrix[i, j]} ");
        };
        Console.WriteLine();
    };
}

void Task02() // решение задачи 2
{
    double[,] y = CreateMass(3, 7);
    FillDoubleMass(y);
    PrintMass(y);
};

//Task02();




int[,] ConvertMass(int[,] mass)
{
    int rows = mass.GetLength(0);
    int columns = mass.GetLength(1);
    for (int i = 0; i < rows; i++) //x
    {
        for (int j = 0; j < columns; j++) //y
        {
            if (mass[i, j] % 2 == 0)
            {
                mass[i, j] *= -1;
            }
        }
    }
    return mass;
};

void Task03() // решение задачи 3
{
    int[,] tass = CreateMatrix(3, 3);
    Fill(tass, 1, 100);
    Print(tass);
    Console.WriteLine();
    tass = ConvertMass(tass);
    Print(tass);
};
//Task03();

