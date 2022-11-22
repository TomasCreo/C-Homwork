// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = 0;
    int lstdgt = 0;
    if (num < 0 ) num = num * -1;
    while (num > 0)
    {
        lstdgt = num % 10;
        sum = sum + lstdgt;
        num = num / 10;
    }

    return sum;
}

Console.WriteLine($"Сумма цифр числа {n} = {SumDigits(n)}");