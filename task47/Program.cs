// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// int[,] RandomMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

void PrintMatrix(double[,] matrix, string str1, string str2)
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

double[,] RandomMatrix(int row, int colum, int min, int max) 
{ 
    double[,] matrix = new double[row, colum]; 
    Random rnd = new Random(); 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            matrix[i, j] = rnd.NextDouble() * (max - min) + min; 
            matrix[i, j] = Math.Round(matrix[i, j], 1); 
        } 
    } 
    return matrix; 
} 

double[,] array2D = RandomMatrix(3, 4, 0, 10);
PrintMatrix(array2D, "|", "|");