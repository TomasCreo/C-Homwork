// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

Console.WriteLine("Введите число для проверки кратности 7 и 23");
int num = Convert.ToInt32(Console.ReadLine());

bool Multiplicity (int number)
{
     return number % 7 == 0 && number % 23 == 0;
}

Console.WriteLine(Multiplicity(num)? "Да" : "Нет");