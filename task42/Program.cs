// Напишите программу, которая будет преобразовывать десятичное число в двоичное. 

string Binary(int num)
{
    string bin = "";
    while (num > 0)
    {
        bin = num % 2 + bin;
        num /= 2;
    }
    return bin;
}
Console.WriteLine($"Введите число которое будет сконвертировано в двоичное");
int number = Convert.ToInt32(Console.ReadLine());
int binary = Convert.ToInt32(Binary(number));
Console.WriteLine($"результат конвертации = {binary}");