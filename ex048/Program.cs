// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

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
            mtrx[i,j] = i + j;
            Console.Write(mtrx[i,j] + " ");
        }
        Console.WriteLine();
    }
    return mtrx;
}

int rowsCount = ReadInt("Введите число строк: ");
int columnsCount = ReadInt("Введите число столбцов: ");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
