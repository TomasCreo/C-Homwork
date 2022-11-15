// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num > 100 ? $"Третья цифра это - {ThirdNumber(num) % 10} " : "Третьей цифры нет");

int ThirdNumber(int number)
{
    while (number > 999)
    {
        number = number / 10;

    }
    return number;
}