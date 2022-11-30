// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.WriteLine($"Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int number1, int number2, int number3)
{
    return number1 < (number2 + number3) && number2 < (number1 + number3) && number3 < (number1 + number2);
}
Console.WriteLine(Triangle(num1, num2, num3) ? $"Треугольник с такими сторонами существует" : $"Нет с такими сторонами не может быть треугольника");