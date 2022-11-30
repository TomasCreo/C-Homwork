// Напишите программу разворачивающую массив

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
void ReverseArray(int [] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}
int [] array1 = RandomArray(length, minimum, maximum);
Console.Write("Элементы массива: ");
PrintArray(array1);
ReverseArray(array1);
PrintArray(array1);
