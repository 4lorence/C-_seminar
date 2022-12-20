// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123


int[] numbers = new int[123];
FillArray(numbers, 0, 150);

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

int count = 0;
for(int i = 0; i<numbers.Length; i++ )
{
  if (numbers[i]>=10 && numbers[i]<100)
    {
      count += 1;
    }
}
Console.WriteLine($"{string.Join(", ", numbers)}");
Console.WriteLine($" -> number of elements from 10 to 99: {count} \n");