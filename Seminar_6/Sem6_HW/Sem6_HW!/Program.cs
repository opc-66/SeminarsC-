// Задача 41: Пользователь вводит с клавиатуры M
//  чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите количество элементов массива");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int [num];
int count = 0;
int i = 0;

for(i = 0; i < array.Length;i++)
{
    Console.WriteLine($"Введите элемент массива {i}");
    array[i] = Convert.ToInt32(Console.ReadLine());

     if(array[i]>0)
    {
        count = count +1;

    }

}
// return array;

Console.WriteLine(string.Join(",", array));
Console.WriteLine($"Количество положительных чисел  {count}");