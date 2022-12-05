// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Enter a three-digit number:");
int N = Convert.ToInt32(Console.ReadLine());

if(N < 99 || N > 999)
{
    Console.WriteLine("it's a three digit number");
}

else
{
int secondN = (N / 10) % 10;

Console.WriteLine($" The second digit of {N} is {secondN}. ");
}