﻿// Задача 15: Напишите программу, которая
//  принимает на вход цифру, обозначающую день
//   недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());
if (num<1)
{
    Console.WriteLine("Такого дня недели нет");
}
if (num > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else if(num==6 || num == 7)
{
    Console.WriteLine("Это выходной");
}
else
{
    Console.WriteLine("Это не выходной");
}
