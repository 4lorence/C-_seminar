// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("day number of the week:");
 int DayN = Convert.ToInt32(Console.ReadLine());

 if(DayN < 1 || DayN > 7)
 {
    Console.WriteLine("wrong number");
 }
 else
 {
    if(DayN == 6 || DayN == 7)
    {
        Console.WriteLine("weekend");
    }
    else
    {
        Console.WriteLine("Weekday");
    }
 }
