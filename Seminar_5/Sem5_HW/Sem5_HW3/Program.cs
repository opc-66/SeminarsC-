// Задача 38: Задайте массив вещественных 
// чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива ");

int n = Convert.ToInt32(Console.ReadLine());
// int res = 0;
int max = Int32.MinValue;
int min = Int32.MaxValue;

int [] array =  GetArray(n);
int [] GetArray(int num)
{
    int [] array = new int[num];

for (int i = 0; i <num; i++)
    {
        array[i] = new Random().Next(1, 100);
        if (array[i] > max)
        {
            max = array[i];
        }
        // min = array[i];
        if (array[i]< min)
        {
            
            min = array[i];

        }
    }
    return array;
}

Console.Write(String.Join(" ", array));
Console.WriteLine();
int res = max - min;

Console.WriteLine("Разница между Макс и Мин " +res);