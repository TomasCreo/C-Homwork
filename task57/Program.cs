// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том сколько раз встречается элемент.

int[,] RandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string sep1, string sep2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{sep1}");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}|");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine($"{sep2}");
    }
}

int[] ChangeToOneString(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k++] = matrix[i, j];
        }
    }
    return array;
}

void CounterValue(int[] array)
{
    int count = 0;
    int num = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) count++;
        else 
        {
            Console.WriteLine($"{num} встречается {count} раз");
            count = 1;
            num = array[i];
        }
    }
    Console.WriteLine($"{num} встречается {count} раз");
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}| ");
        else Console.Write($"{array[i]}");
    }
    Console.Write($"]");
}
int stringsize = 0;
int columsize = 0;
int stringIndex = 0;
int columIndex = 0;
while (stringsize <= 0 || columsize <= 0)
{
    Console.WriteLine($"Введите количество сторок");
    stringsize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите количество столбцов");
    columsize = Convert.ToInt32(Console.ReadLine());
    if (stringsize <= 0 || columsize <= 0)
        Console.WriteLine("Введены неверные данные");
}
int[,] array2D = RandomMatrix(stringsize, columsize, 0, 9);
PrintMatrix(array2D, "|", "|");
int[] newarray = ChangeToOneString(array2D);
Console.WriteLine();
PrintArray(newarray);
Array.Sort(newarray);
Console.WriteLine();
CounterValue(newarray);
