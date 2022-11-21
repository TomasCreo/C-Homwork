// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите число для проверки на полиндром");
int num1 = Convert.ToInt32(Console.ReadLine());

bool Reverse(int number1)
{
    int temp = number1;
    int rev = 0;
    while (number1 != 0)
    {
    int digit = number1 % 10;
    rev = rev * 10 + digit;
    number1 = number1 / 10;
    }
    
    return rev == temp;
}
Console.WriteLine(Reverse(num1) ? "Это полиндром" : $"Это не полиндром" );
