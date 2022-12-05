using System;
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double[] SumOfColumElelmnts(int[,] matrix, int colums)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double sum = 0;
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                sum += matrix[k, i];
                array[i] = Math.Round(sum / matrix.GetLength(0),2);
            }
        }
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}| ");
        else Console.Write($"{array[i]}");
    }
    Console.Write($"]");
}
void PrintMatrix(int[,] matrix, string str1, string str2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{str1}");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}|");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine($"{str2}");
    }
}

int stringsize = 0;
int columsize = 0;
while (stringsize <= 0 ||columsize <= 0)
{
    Console.WriteLine($"Введите количество сторок");
    stringsize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите количество столбцов");
    columsize = Convert.ToInt32(Console.ReadLine());
    if (stringsize <= 0 ||columsize <= 0) Console.WriteLine("Введены неверные данные");
}
int[,] array2D = RandomMatrix(stringsize, columsize, 0, 10);
double[] arr1 = SumOfColumElelmnts(array2D, columsize);
PrintMatrix(array2D, "|", "|");
PrintArray(arr1);