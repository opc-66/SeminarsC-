﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите длину массива ");

int n = Convert.ToInt32(Console.ReadLine());
int count = 0;

int [] array =  GetArray(n);
int [] GetArray(int num)
{
    int [] array = new int[num];

for (int i = 0; i <num; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i]%2 ==0)
        {
            count = count + 1;
        }
    }
    return array;
}
Console.Write(String.Join(" ", array));
Console.WriteLine();
Console.WriteLine("Количество четных чисел " +count);
    
