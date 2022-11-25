// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
string res = Console.ReadLine();
int num = Convert.ToInt32(res);

if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(res[2]);
}