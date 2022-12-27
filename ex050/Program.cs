// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int rows = ReadInt("Enrer the number of rows in the array: ");
int colums = ReadInt("Enrer the number of columns in the array: ");
int[,] numbers = new int[6, 8];
FillArray(numbers);
PrintArray(numbers);

if 
(rows < numbers.GetLength(0) && colums < numbers.GetLength(1))
{
Console.WriteLine(numbers[rows, colums]);
}
else 
Console.WriteLine($"{rows} {colums} -> there are no such numbers in the array");



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + ", ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}