 // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// int ReadInt(string msg)
// {
//     Console.WriteLine(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int num = ReadInt("Enter N:");
// int numd = num;
// int i = 1;
// for(; numd != 0;i++)
// {
//     numd = numd/2;
// }
// int[] array = new int[i];
// for(;num != 0;i--)
// {
//     array[i-1] = num%2;
// }
// Console.WriteLine(string.Join(",",array));

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int num = ReadInt("Enter N:");


void PrintBinaryView(int num)
{
    if (num <= 0) return;
    PrintBinaryView(num/2);
}
int[] array = new int[num];
PrintBinaryView(array);
Console.WriteLine(string.Join(",",array));