// Задача 65: Задайте значения M и N. 
// Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

void NaturalNums(int number1, int number2)
{
    if (number1 < number2)
    {
        Console.Write($"{number1} ");
        NaturalNums (number1 +1, number2);
    }
    else if (number2 < number1)
    {
        Console.Write($"{number1} ");
        NaturalNums (number1 - 1, number2);
    }
    else  Console.Write($"{number2} ");
} 

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
NaturalNums(num1, num2);