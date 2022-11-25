// Задать массив из 12 элементов, заполненных числами из [-9,9]. 
// Найти сумму положительных/отрицательных элементов массива


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

int SumPosiveArray(int[] array)
{
    int sumdigits = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0) 
        {
            sumdigits = sumdigits + array[i];
        }
    }
    return sumdigits;
}
int SumNegativeArray(int[] array)
{
    int sumdigits = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < 0) 
        {
            sumdigits = sumdigits + array[i];
        }
    }
    return sumdigits;
}

int [] array1 = RandomArray(length, minimum, maximum);
Console.Write("Элементы массива: ");
PrintArray(array1);
Console.WriteLine();
int sumpositive =  SumPosiveArray(array1);
Console.WriteLine($"Сумма положительных элементов массива = {sumpositive}");
int sumnegative = SumNegativeArray(array1);
Console.WriteLine($"Сумма отрицательных элементов массива = {sumnegative}");