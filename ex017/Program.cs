﻿// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("enter dot x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter dot y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 $$ y > 0)
{
    Console.WriteLine("1 quater");
}

if (x < 0 $$ y > 0)

{
    Console.WriteLine("2 quater"); 
}

if (x < 0 $$ y < 0)

{
    Console.WriteLine("3 quater"); 
}

if (x > 0 $$ y < 0)
{
    Console.WriteLine("4 quater"); 
}
