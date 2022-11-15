// Напишите программу, которая выводитслучайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 это - {num}");
// int firstdgt = num / 10;
// int lstdgt = num % 10;
// if (firstdgt > lstdgt) Console.WriteLine($"Наибольшая цифра числа {num} это {firstdgt}");
// else Console.WriteLine($"Наибольшая цифра числа {num} это {lstdgt}");

int MaxDigit (int number)
{
    int firstdgt = number / 10;
    int lstdgt = number % 10;
    if (firstdgt > lstdgt) return firstdgt;
    return lstdgt;
}
int maxDigigt = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра числа {num} это {maxDigigt}");