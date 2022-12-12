// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int SumOfEllements (int a, int b)
{ 
    if (a == b) return b;
    return SumOfEllements(a + 1, b) + a;
}

int result = SumOfEllements(num1, num2);
Console.WriteLine(result);
