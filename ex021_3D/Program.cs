// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D.

Console.Write("Enter coordinates x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter coordinates x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter coordinates y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter coordinates y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter coordinates z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter coordinates z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"The distance between two points in space is {distance:f2}");
                