//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на 
//выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("enter number N:");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = -N; i <= N; i++)
{
    Console.Write(i + " ");
}