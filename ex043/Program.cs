// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double InputCoordinate(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToDouble(Console.ReadLine());
}
double b1 =InputCoordinate("Enter k1 from y = k1 * x + b1:");
double k1 =InputCoordinate("Enter b1 from y = k1 * x + b1:");
double b2 =InputCoordinate("Enter k2 from y = k2 * x + b2:");
double k2 =InputCoordinate("Enter b2 from y = k2 * x + b2:");
double x;
double y;
if (k1==k2)
{
    Console.WriteLine("Lines don't cross.");
}
else 
{
    x=(b2-b1)/(k1-k2);
    y=k1*x+b1;
    Console.WriteLine($"Intersection at point x = {x}, y = {y}.");
}