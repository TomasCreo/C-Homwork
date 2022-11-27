//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine($"Задайте длинну массива!");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте левую границу массива от 0");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте правую границу массива до 9");
int maximum = Convert.ToInt32(Console.ReadLine());
double [] RandomArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.NextDouble() * (max - min) + min;
            array[i] = Math.Round(array[i], 1);
        }
    return array;
}
void PrintArray(double[] array)
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
double FindDiffrence(double[] array)
{
    double max = 0;
    double min = 0;
    double difirence = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            max = array[i];
            min = max;
        }
        else if (array[i] < min) min = array[i];
        difirence = max - min;
    }
    return difirence;
}

double [] array1 = RandomArray(length, minimum, maximum);
Console.Write("Элементы массива: ");
PrintArray(array1);
Console.WriteLine($"{FindDiffrence(array1)} - разница между максимальным и минимальным элементом");
