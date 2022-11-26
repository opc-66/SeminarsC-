// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] array = GetArray(8);

int [] GetArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i <num; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}



Console.Write(String.Join(" ", array));
