// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("enter a five-digit number");
int N = Convert.ToInt32(Console.ReadLine());

int div = N /10000;
int rem = N % 10;

if(N >= 10000)
{
    div = N / 10000; 
    rem = N % 10; 
    if (div == rem)
     {
            N = N /10;
            int div1 = (N / 100) % 10;
            int rem2 = N % 10;
                Console.WriteLine($"yeah, number {N} palindrome");
     
     }
     else
        {
            Console.WriteLine($"no, number {N}  not a palindrome");
        }  
}
else
{
    Console.WriteLine("incorrect number");
}


