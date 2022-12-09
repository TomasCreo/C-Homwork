// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
int MatrixPosition(int[,] matrix, int stringI, int columI)
{
    int position = matrix[stringI, columI];
    return position;
}

int stringsize = 0;
int columsize = 0;
int stringIndex = 0;
int columIndex = 0;
while (stringsize <= 0 || columsize <= 0 || stringIndex < 0 || columIndex < 0)
{
    Console.WriteLine($"Введите количество сторок");
    stringsize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите количество столбцов");
    columsize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите индекс стороки");
    stringIndex = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите индекс столбца");
    columIndex = Convert.ToInt32(Console.ReadLine());
    if (stringsize <= 0 || columsize <= 0 || stringIndex < 0 || columIndex < 0) 
    Console.WriteLine("Введены неверные данные");
}
int[,] array2D = RandomMatrix(stringsize, columsize, 0, 10);
PrintMatrix(array2D, "|", "|");
Console.WriteLine(stringIndex <= stringsize & columIndex <= columsize ?
$"{MatrixPosition(array2D, stringIndex, columIndex)} - Элемент массива под заданным индексом" :
 "Такого элемента в массиве нет");

