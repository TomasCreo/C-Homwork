// Задайте двумерный массив размера m на n, 
// кажыдй элемент массива находится по формуле: Amn = m+n

int[,] RandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
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

int[,] array2D = RandomMatrix(3, 4, 0, 10);
PrintMatrix(array2D, "|", "|");