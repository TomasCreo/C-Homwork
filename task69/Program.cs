// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для возведения в степень первого числа");
int num2 = Convert.ToInt32(Console.ReadLine());

int PowerRecMath (int a, int n)
{   
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath (a * a, n / 2);
    else return PowerRecMath (a, n - 1) * a;
}

int result = PowerRecMath(num1, num2);
Console.WriteLine(result);
