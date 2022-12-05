// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Enter a three-digit number:");
int N = Convert.ToInt32(Console.ReadLine());

if(N > 1000)
{
    Console.WriteLine("it's a three digit number");
}

else
{
int tempN = N / 10;
int res = tempN % 10;
Console.WriteLine(res);
}