// Напишите программу, кот принимает на вх
//  трехзначное число и на вых показывает вторую цифру эт числа

int num = new Random().Next(100,1000);

Console.WriteLine(num);

int res = (num/10)%10;

Console.WriteLine(res);

