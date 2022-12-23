// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"


Console.WriteLine("Enter the number. Type 'end' to end: "); 
int count = 0; 
 
while (true) 
{ 
  string N = Console.ReadLine(); 
  if (N == "end") 
  { 
    break; 
  } 
  else if ((Convert.ToInt32(N) > 0)) 
  { 
    count++; 
  } 
 
} 
Console.WriteLine(count);