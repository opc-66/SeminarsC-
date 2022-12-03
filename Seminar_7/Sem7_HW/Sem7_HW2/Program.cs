﻿// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном
//  массиве, и возвращает значение этого элемента или же
//  указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Input m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input n");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [m, n];

for (int i=0; i< matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        matrix [i, j]= new Random().Next(0, 10);
        
        Console.Write(matrix[i,j] +" ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите номер строки");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца");
int b = Convert.ToInt32(Console.ReadLine());

if (a<m&&b<n)
{
    Console.WriteLine("Элемент массива " + matrix[a,b]);
}
else
Console.WriteLine("Элемента с таким номером нет");