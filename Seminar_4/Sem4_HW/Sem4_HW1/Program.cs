// Задача 25: Напишите цикл, который
//  принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число 1 ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2 ");
int B = Convert.ToInt32(Console.ReadLine());

int Pow(int num1, int num2)
{
    int result = 1;
    for (int i=0; i <num2; i++)  //i=0 если i<num2 тогда
    {
        result *= num1;           // result=result*num1 ->//i=i+1
    }
    return result;                               
}

int res = Pow(A, B);
Console.WriteLine(res);