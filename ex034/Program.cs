// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array= new int[123];

for(int i=0; i<array.Length; i++)
{
    array[i]= new Random().Next(1,151);
}    
int countEven=0;
for(int j=0;j<array.Length; j++)
{
    if(array[j]%2==0)
    {
        countEven++;
    }
}

Console.WriteLine($"{string.Join(", ", array)}");
Console.WriteLine($" -> In this array are {countEven} even elements.");
