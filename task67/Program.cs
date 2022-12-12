// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumOfDigts(int number)
{
    number > 0 ? number % 10 + SunOfNumbers(number /10) : 0;
}

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
int result = SumOfDigts(num1);
Console.WriteLine(result);