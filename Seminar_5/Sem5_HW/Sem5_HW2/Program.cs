// Задача 36: Задайте одномерный массив, заполненный
//  случайными числами. Найдите сумму элементов, 
//  стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива ");

int n = Convert.ToInt32(Console.ReadLine());
int res = 0;

int [] array =  GetArray(n);
int [] GetArray(int num)
{
    int [] array = new int[num];

for (int i = 0; i <num; i++)
    {
        array[i] = new Random().Next(-100, 100);
        if (i%2 !=0)
        {
            res = res+ array[i];
        }
    }
    return array;
}
Console.Write(String.Join(" ", array));
Console.WriteLine();
Console.WriteLine("СУмма чисел на нечетных позициях " +res);