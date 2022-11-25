// 32 Написать программу замену элементов массива на противоположные

Console.WriteLine($"Задайте длинну массива, например 12");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте левую границу массива");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте правую границу массива");
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
    Console.Write($"]");
}
void NegativeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *=-1;
}

int [] array1 = RandomArray(length, minimum, maximum);
Console.Write("Элементы массива: ");
PrintArray(array1);
Console.WriteLine();
Console.Write("Противоположные элементы массива: ");
NegativeArray(array1);
PrintArray(array1);