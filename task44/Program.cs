// Не используя рекурсию, выведите первые N чисел Фибоначи

Console.WriteLine($"Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

int [] Fibonacci(int number)
{

    int [] array = new int [number];
    array[1] = 1;
    for(int i =2; i < number; i++ )
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}

int [] ResultArray = Fibonacci(num1);
PrintArray(ResultArray);