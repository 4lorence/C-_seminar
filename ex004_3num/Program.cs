//Задача 4: Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел.

Console.WriteLine("enter number1:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter number2:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter number3:");
int num3 = Convert.ToInt32(Console.ReadLine());

int mx = num1;

if(num2 > num1)
{
    mx = num2;
}
if(num3 > mx)
{
    mx = num3;
}
Console.Write("max number=");
Console.WriteLine(mx);