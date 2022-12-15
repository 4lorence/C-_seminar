// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"квадрат чисел от 1 до {n} равен {i*i}");
}
