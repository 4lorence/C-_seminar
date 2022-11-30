//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("enter number1:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter number2:");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Number1 > Number2");
}
else if(num1 < num2)
{
    Console.WriteLine("Number1 < Number2");
}
else
{
    Console.WriteLine("Number1 = Number2");
}