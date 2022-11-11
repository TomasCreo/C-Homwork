
// Напишите программу которая на вход принимает два числа и провекряет является ли первое число квадратом второго.
Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (num == square) Console.WriteLine($"Да");
else Console.WriteLine($"Нет");
