// Определить, присутствует ли в заданном массиве, некоторое число

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
int RandomNumber(int numrnd)
{
    Random rndnum = new Random(); 
    numrnd = rndnum.Next(0, 99);
    return numrnd;
}
int FindNum(int numrnd, int[] array, int count)
{
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numrnd) count = count + 1;
    }
    return count;
}
int num = 0;
int [] array1 = RandomArray(length, minimum, maximum);
int counter = 0;
int result = FindNum(num, array1, counter);
Console.Write("Элементы массива: ");
PrintArray(array1);
Console.WriteLine();
Console.Write("Случайное число: ");
Console.WriteLine(RandomNumber(num));
Console.WriteLine(counter > 0 ? $"Массив содержит число" : $"Не содержит случайное число" );