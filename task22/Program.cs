// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int n = -1;
while (n < 1)
{
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены неверные данные");
}

void Quarter (int num)
{   
    int count = 1;
    while (count <= num)
    {   
        Console.WriteLine($" Число - {count} И его квадрат {count*count}");
        count++;
    }
}
Quarter (n);