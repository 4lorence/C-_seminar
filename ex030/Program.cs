﻿// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] array = new int[14];
int  N = new Random().Next(0,2);
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);   
}
Console.WriteLine(string.Join(", ", array));