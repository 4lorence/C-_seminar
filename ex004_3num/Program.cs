//Задача 4: Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел.

Console.WriteLine("enter number1:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter number1:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter number1:");
int num3 = Convert.ToInt32(Console.ReadLine());

int mx = 

if(num2 > num1)
{
    int mx = num2;
}
 else if(num3 > mx)
{
    int mx = num3;
}
Console.WriteLine("max number="+ mx);