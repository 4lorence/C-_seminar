// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// ​ (в примере подсчет индексов начинаетя с 1 ,с как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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
void SquareMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i += 2)
    {
        for (int j = 0; j < matr.GetLength(1); j += 2)
        {
            matr[i, j] *= matr[i, j];
        }
    }
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
SquareMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);
