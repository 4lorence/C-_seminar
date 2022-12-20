// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Console.WriteLine("enter N");
int N = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[N];
mass[0] = 0;
mass[1] = 1;

    for(int i = 2; i < mass.Length; i++)
    {
        mass[i] = mass[i-1]+mass[i-2];
    }
    Console.WriteLine($"{string.Join(", ", mass)}");
