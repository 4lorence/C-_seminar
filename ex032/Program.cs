// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void fillarray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
    }
}
void findDigit(int[] array, int digit)
{
bool find =false;
{
    for(int i=0; i < array.Length; i++)
    {
        if(array[i]==digit) 
        {
            find=true;
        }
        if(find==true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        }
    }

}
Console.Write("enter N:");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[7];
fillarray(array);
Console.WriteLine($"{string.Join(", ", array)}");
findDigit(array,N);