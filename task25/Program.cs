// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = -1;
while (n2 < 0)
{
    Console.WriteLine("Введите второе натуральное число");
    n2 = Convert.ToInt32(Console.ReadLine());
    if (n2 < 0) Console.WriteLine("Введены неверные данные");
}


int Degree(int number1, int number2)
{
    int mult = 1;
    for (int i = 0; i < number2; i++)
    {
        mult = mult * number1;
    }
    
    return mult;
}

Console.WriteLine($"Число {n1} в стпени {n2} = {Degree(n1, n2)}");