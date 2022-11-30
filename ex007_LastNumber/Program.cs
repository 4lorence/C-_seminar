//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Enter a three-digit number:");
int N = Convert.ToInt32(Console.ReadLine());

int LastN = N % 10;

Console.WriteLine(LastN);