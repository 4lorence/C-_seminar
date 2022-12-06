// Задача 20: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("enter x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter y2");
int y2 = Convert.ToInt32(Console.ReadLine());

double x = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
// double x = Math.Sqrt(Math.Pow(x2-x1,2));
// double y = Math.Sqrt(Math.Pow(y1-y2,2));
// double res = x + y;
Console.WriteLine(res);