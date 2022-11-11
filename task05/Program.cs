// Напишите программу которая на вход принимает одно число N, а на выходе показывает все целые числа в промежутке от -N до N
Console.WriteLine("Введите целое число число");
int num = Convert.ToInt32(Console.ReadLine());
int count = -num;
if ( num > 0)
{
    while (count <= num)
    {
        Console.Write(count + ", ");
        count++;
    }
}
else Console.WriteLine("Введено некоректное значение");