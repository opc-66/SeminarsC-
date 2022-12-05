// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] array = new int[4,4];
int count = 0;
int i = 0;
int j =0;

for (j =0; j<array.GetLength(1); j++) // 0 str
{    
    array[i, j]= 1 + count;
    count = count + 1;
}

for ( i = 1; i< array.GetLength(0); i++) //3 stol
{
    j = 3;
    array[i,j] = 1+ count;
    count = count +1;

}

for (  j = 2; j>= 0; j=j-1) // 3 str
{
    i = 3;
    array[i,j] = 1 + count;
    count++;
}

for ( i = 2; i>=1; i=i-1) // 0 stol
{
    j=0;
    array[i,j] = 1+ count;
    count++;
}

for ( j =1; j<=2; j++) // 1 str
{
    i=1;
    array[i,j]= 1 + count;
    count = count + 1;
}

for ( j = 2; j>= 1; j=j-1) // 2 str
{
    i = 2;
    array[i,j] = 1 + count;
    count++;
}

for ( i = 0; i<array.GetLength(0); i++)
{
    for ( j=0; j<array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t ");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");
