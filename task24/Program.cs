// НАпишите программу, которая которая принимает на входе число (А) и выдает и выдает сумму чисел от 1 до А.

int n = -1;
while (n < 1)
{
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены неверные данные");
}

int Sum (int num)
{   
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    
    return sum;
}

Console.WriteLine($"Сумма чиселт от 1 до {n} = {Sum (n)}");
