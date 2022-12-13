// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int 
int ReadInt(string msg1)
{
Console.Write(msg1);
return Convert.ToInt32(Console.ReadLine());
} 
int Exp (int numA, int numB)
{
int exponent = 1;
for(int i = 1; i <= numB; i++)
    {
        exponent = exponent * numA;
    }
return exponent;
}
int numA = ReadInt("enter A: ");
int numB = ReadInt("enter B: ");
int result = Exp(numA,numB);
Console.WriteLine(result);