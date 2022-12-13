// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Readint(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int countToN(int N)
{
    int count = 0;
    while(N !=0)
    {
        N /= 10;
        count++;
    }
    return count;
}
int num = Readint("enter N");
int result = countToN(num);
Console.WriteLine(result);