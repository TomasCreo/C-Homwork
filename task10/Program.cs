// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(((num > 99) && (num < 1000)) || ((num < -99) && (num > -1000)) ? $"Вторая цифра это - {SecondNumber(num)} " : "Число не трехзначное");

int SecondNumber (int number)
{ 
     if (number < -99)
    {
      number = number * -1;
    }
    number = number / 10 % 10;
    return number;
}
