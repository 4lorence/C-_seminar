//  Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


int N = new Random().Next(10,100);
int LastN = N % 10;
int N10 = N / 10;
// Console.WriteLine("Random number=" + N "first number=" + N10 "second number=" + LastN);
Console.WriteLine($"random number ={N}, first number = {N10}, second number = {LastN}");
int max = N10;
if(max < LastN)
{
    max = LastN;
}
Console.WriteLine(max);
