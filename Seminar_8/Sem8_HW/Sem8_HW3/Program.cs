// Задача 58: Задайте две матрицы. Напишите 
// программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите кол-во строк");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во колонок");
int m = Convert.ToInt32(Console.ReadLine());

int [,] array= new int [n,m];

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
    
}
Console.WriteLine("________________");

int [,] array2= new int [n,m];
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next(0,10);
            Console.Write(array2[i,j] + " ");
        }
        Console.WriteLine();
    }
    
}
Console.WriteLine("___________");

int [,] array3= new int [n,m];
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            int sum =0;
            for (int k = 0; k< array.GetLength(1); k++)
            {
                sum = sum +array[i,k] * array2[k,j];
            }
            Console.Write((array3[i,j] = sum) + " ");
        }
        Console.WriteLine();
    }
    
}
Console.WriteLine("___________");