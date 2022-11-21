
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


// Console.WriteLine("To know whether it's weekend or not, enter the day number starting from 1 to 7: ");
//  int numberofday = Convert.ToInt32(Console.ReadLine());

// int WeekDay(int day)
// {
//     if (day < 1 || day > 7)
//     {
//         Console.WriteLine("There is only 7 days in a week. Enter the real day number you need.");
//     }
//     else if (day > 5)
//     {
//         Console.WriteLine("It's a weekend. Just chill");
//     }

//     else
//     {
//        Console.WriteLine("It's a workday, unfortunatelly. Sorry for you, bro");
//     }
//     return day;
// }
// Console.WriteLine(WeekDay(numberofday));