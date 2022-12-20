// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GetRandomMatrix(int rows, int columns, int leftrange = 0, int rightrange = 10)
{
    int[,] mtrx = new int[rows, columns];
    var rand = new Random();
    for(int i = 0; i < mtrx.GetLength(0); i++)
    {
        for(int j = 0; j <mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = rand.Next(leftrange, rightrange +1);
            // onsole.Write(mtrx[i,j] + " ");C
        }
    //     Console.WriteLine();
    }
    return mtrx;
}

int SumMatrix(int[,] matr)
{
    int tmp = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        tmp = tmp + matr[i,i];
    }
    return tmp;
}

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
    }
}

int rowsCount = ReadInt("Введите число строк: ");
int columnsCount = ReadInt("Введите число столбцов: ");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
// SumMatrix(matrix);

Console.WriteLine(SumMatrix(matrix));

