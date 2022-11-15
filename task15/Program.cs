
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 7)
{
     Console.WriteLine($"Число {num} не явялется днем недели");
}
// else
// {
//     Console.WriteLine(num > 5 ? "Да, этот день выходной": "Нет, это будни");
// }

else
{
    Console.WriteLine(DayofTheWeek(num) ? "Да, это выходной" : "Нет, это будни"); 
} 
bool DayofTheWeek(int number) 
{ 
    return (number == 6) || (number == 7);
}