// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int Degree(int number1, int number2)
{
    int mult = 1;
    for (int i = 0; i < number2; i++)
    {
        mult = mult * number1;
    }
    
    return mult;
}

Console.WriteLine($"Число {n1} в чтпени {n2} = {Degree(n1, n2)}");