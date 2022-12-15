// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
    Console.Write("enter number array elements:");
    int elementsCount = Convert.ToInt32(Console.ReadLine());

    int[]array = new int[elementsCount];

for(int i = 0; i < array.Length; i++)
    {   
        Console.Write($"enter array element {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

Console.WriteLine($"{string.Join(", ", array)}");
   

