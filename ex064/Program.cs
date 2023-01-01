// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

int number = ReadInt("Enter N: ");
int m=1;
Console.Write($"N = {number} -> ");
Console.Write(NaturalNumbers(number,m));

int NaturalNumbers(int n, int m)
{
    if (n == m)
        return n;
    else
    {
        Console.Write(NaturalNumbers(n,m+1)+", ");
    }
    return m;
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}