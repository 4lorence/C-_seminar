//Задача №3. Напишите программу, которая будет выдавать название 
//дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.WriteLine("enter num:");
int x = Convert.ToInt32(Console.ReadLine());

if(x == 1)
{
    Console.WriteLine("Monday");
}

if(x == 2)
{
    Console.WriteLine("Tuesday");
}

if(x == 3)
{
    Console.WriteLine("Wednesnday");
}

if(x == 4)
{
    Console.WriteLine("Thursday");
}

if(x == 5)
{
    Console.WriteLine("Sunday");
}

if(x == 6)
{
    Console.WriteLine("Saturday");
}
if(x>7 || x < 1)
{
    Console.WriteLine("oops");
}