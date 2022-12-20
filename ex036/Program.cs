// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int number = ReadIn("Enter the number of array elements: ");
int[] array= new int[number];

FillArrayRandomNumbers(array);//функция заполнения массива
Console.WriteLine($"{string.Join(", ", array)}");

int sumOdd=0;
for(int j=1;j<array.Length; j+=2)
{
    sumOdd+=array[j];
}

Console.WriteLine($" -> The sum of odd array elements is {sumOdd}.");

int ReadIn(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]= new Random().Next(-10,11);
    }
}
