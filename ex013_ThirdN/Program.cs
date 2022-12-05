// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter any number");
int N = Convert.ToInt32(Console.ReadLine());
int userN = N;
if(N < 0)
{
    N = - N;
}
if(N <= 99)
{
    Console.WriteLine("Wrong number");
}
else
{
    while(N > 999)
    {
        N = N / 10;
    }
    int thirdN = N % 10;
    Console.WriteLine($"The third digit of {userN} is {thirdN}.");
}

