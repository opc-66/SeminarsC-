// Задача 26: Напишите программу, которая
//  принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetCounNum(int res)
{

int count =0;

while(res>0)
{
count++;  //
res/=10;   //res=res/10

}
return count;

}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Колличество цифр "+GetCounNum(num));