using System;
internal class Program
{
    private static void Main(string[] args)
    {
        // Task00 Напишите программу, которая на вход принимает число и возводит его в квадрат.
        Console.WriteLine("Введите целое число");

        int num = Convert.ToInt32(Console.ReadLine());
        int square = num * num;
        Console.WriteLine($"Квадрат числа {num} = {square}");
    }
}