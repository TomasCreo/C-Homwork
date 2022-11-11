//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num > num2) Console.WriteLine($"Max = {num} Min = {num2}");
else Console.WriteLine($"Max = {num2} Min = {num}");