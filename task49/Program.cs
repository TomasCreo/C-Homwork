// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные 
// и замените эти элементы на их квадроаты. 

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
int[,] SqureEvenIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
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
Console.WriteLine($"");
SqureEvenIndex(array2D);
PrintMatrix(array2D, "|", "|");
