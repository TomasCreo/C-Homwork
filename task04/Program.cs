//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
int [] arr = {num, num2, num3}; // Задаем массив из полученных чисел
Console.WriteLine($"Максимальное число = " + arr.Max()); // используем команду "Max" для нахождения максимального числа в массиве. На каникулах учил питон)))

