// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int start = ReadInt("Enter N: ");
int end = ReadInt("Enter M: ");
if (end<start)
{
    int temp = start;
    start = end;
    end = temp;
}
Console.Write($"N = {start}; M = {end} -> ");
Console.Write(SumNaturalNumbers(start,end));

int SumNaturalNumbers(int n, int m)
{
    if (m==n)        
        return m;
    return m + SumNaturalNumbers(n,m-1);
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
