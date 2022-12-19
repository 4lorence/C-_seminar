// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int number = ReadIn("Enter the number of array elements: ");
int [] array= new int[number];

FillArrayRandomNumbers(array);//функция заполнения массива
Console.WriteLine($"{string.Join(", ", array)}");

int max=array[0];
int min=array[0];
for(int j=0;j<array.Length; j++)
{
    if (array[j]>max)
    {
        max=array[j];
    }
    else if (array[j]<min)
    {
        min=array[j];
    }
}

Console.WriteLine($"The max array elements is {max}.");
Console.WriteLine($"The min array elements is {min}.");
Console.WriteLine($"The max difference between max and min is {max-min}.");

int ReadIn(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]= Convert.ToInt32(new Random().Next(-10,11));
    }
}


