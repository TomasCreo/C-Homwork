
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num > 5 ? "Да, этот день выходной": "Нет, это будни");

// Решение через метод слишком большое по этому оставил вариант, что выше.
// Console.WriteLine(DayofTheWeek(num) ? "Да" : "Нет"); 
 
// bool DayofTheWeek(int number) 
// { 
//     return (number == 6) || (number == 7); 
// }