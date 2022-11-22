// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int n = 0;
while (n <= 0)
{
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0) Console.WriteLine("Введены неверные данные");
}

int Mult (int num)
{   
    int mult = 0;
    for (int i = 0; i <= num; i++)
    {
        mult = mult * i;
    }
    
    return mult;
}

Console.WriteLine($"Произведение чисел от 1 до {n} = {Mult (n)}");