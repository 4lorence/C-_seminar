// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadInt(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
} 
//вовзвращает сумму 1 to N
int Sum1toN(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
    sum += i;
    }
    return sum;
}

int A = ReadInt("enter N");
int summary = Sum1toN(A);
Console.WriteLine($"sum 1 to {A} = {summary}");
