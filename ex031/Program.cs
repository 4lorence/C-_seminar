// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange +1);
    }
    return array;
}
//1.возвращаемая сумма положительных элементов
//2.возвращаемая сумма отрицательных элементов
(int, int) sumPosAndNeg(int[] array) 
{
    int sumPos = 0;
    int sumNeg = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) //если элемент положительный
        {
            sumPos +=array[i]; //копить положительную сумму
        }
        else //иначе элемент отрицательный или ==0
        {
            sumNeg +=array[i];
        }
    }
    return (sumPos, sumNeg);
}
const int LENGTH = 12;
const int LEFT = -9;
const int RIGHT = 9;
int[] mass = GetRandomArray(LENGTH, LEFT, RIGHT);
Console.WriteLine(string.Join(", ", mass));
(int sumP, int sumN) = sumPosAndNeg(mass);
Console.WriteLine($"{sumP}, {sumN}");