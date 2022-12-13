// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadInt(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
} 
//вовзвращает сумму 1 to N
int Sum1toN(int num)
{
    int sum = 1;
    for(int i = 1; i <= num; i++)
    {
    sum *= i;
    }
    return sum;
}

int A = ReadInt("enter N");
int summary = Sum1toN(A);
Console.WriteLine($"multiplication 1 to {A} = {summary}");