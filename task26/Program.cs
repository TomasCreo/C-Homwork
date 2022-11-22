// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int CountDigits(int num)
{
    int count = 0;
    if (num < 0 ) num = num * -1;
    while (num > 0)
    {
        count++;
        num = num / 10;
    }

    return count == 0 ? count = 1 : count;
}

Console.WriteLine($"Колличество цифр в числе {n} = {CountDigits(n)}");