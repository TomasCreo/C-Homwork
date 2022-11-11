// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.Write($"Четные числа от 1 до {num} это: ");
while (count <= num)
{
    if ( count % 2 == 0)
    Console.Write($"{count},");
    count++;
}

