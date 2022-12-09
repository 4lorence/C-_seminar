// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("enter a five-digit N: ");
int N = Convert.ToInt32(Console.ReadLine());

int num1 = N / 10000 % 10;
int num2 = N / 1000 % 10;
int rev1 = N / 10 % 10;
int rev2 = N % 10;
int nul = N / 10000;
        
if (nul < 1 || nul > 9)
    {
    Console.WriteLine($"{N}Not 5-digit N");
    }
    else if  (num1 == rev2 && num2 == rev1)
    {
        Console.WriteLine($"Yes, this is {N} palindrom");
    }
    else
    {
        Console.WriteLine($"No, this is {N}  not palindrom");
    }




