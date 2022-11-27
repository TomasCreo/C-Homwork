// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine($"Задайте длинну массива!");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте левую границу массива от 100");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте правую границу массива до 999");
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

int FindDividedByTwo(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count ++;
    }
    return count;
}
int [] array1 = RandomArray(length, minimum, maximum);
Console.Write("Элементы массива: ");
PrintArray(array1);
Console.WriteLine($"{FindDividedByTwo(array1)} - колличество четных чисел");