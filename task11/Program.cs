// Напишши программу которая выводит случайное трех значное число и удаляет вторую цифру этого числа.
int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 10 - 99 это - {num}");

int DeletSecondDigit (int number)
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    return firstDigit * 10 + lastDigit;
}
int resultDigit = DeletSecondDigit(num);
Console.WriteLine($"Удаляем вторую цифру в числе {num}");
Console.WriteLine($"Результат {resultDigit}");