// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int N = new Random().Next(100,1000);
Console.WriteLine(N);

int firstN = N /100;
int lastN  = N % 10;
int res = firstN * 10 + lastN;

Console.WriteLine(res);
