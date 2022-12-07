// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.


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

int [,] ChangeStrngToColumn(int[,] matrix)
{
    int [,] matrix2 = new int [matrix.GetLength(0),matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix2[i, j] = matrix[j,i];
        }
    }
    return matrix2;
}

int stringsize = 0;
int columsize = 0;
int stringIndex = 0;
int columIndex = 0;
while (stringsize <= 0 || columsize <= 0 || columsize != stringsize)
{
    Console.WriteLine($"Введите количество сторок");
    stringsize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите количество столбцов");
    columsize = Convert.ToInt32(Console.ReadLine());
    if (stringsize <= 0 || columsize <= 0 || columsize != stringsize)
    Console.WriteLine("Введены неверные данные");
}
int[,] array2D = RandomMatrix(stringsize, columsize, 0, 10);
PrintMatrix(array2D, "|", "|");
int[,] newArray2D =  ChangeStrngToColumn(array2D);
Console.WriteLine();
PrintMatrix(newArray2D, "|", "|");