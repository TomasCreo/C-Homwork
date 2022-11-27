// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine($"Задайте длинну массива!");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте левую границу массива от 0");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте правую границу массива до 9");
int maximum = Convert.ToInt32(Console.ReadLine());
int [] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(min, max+1);
        }
    return array;
}
void PrintArray(int[] array)
{
    Random rnd = new Random();
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}
int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum = sum + array[i];
    }
    return sum;
}
int [] array1 = RandomArray(length, minimum, maximum);
Console.Write("Элементы массива: ");
PrintArray(array1);
Console.WriteLine($"{FindSum(array1)} - Сумма нечетных");