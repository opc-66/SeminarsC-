﻿// Задача 52. Задайте двумерный массив из целых 
// чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
Console.WriteLine("__________");

double sum = 0;

for(int j=0; j<matrix.GetLength(1); j++)
{
    for (int i=0; i< matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i, j];
    }
    double res = Math.Round(sum/matrix.GetLength(0), 2);
    sum = 0;
    Console.Write(res + " ");
}

