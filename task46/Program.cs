// Задача 46. Задайте двумерный массив заполененный случайными числами

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

// // double[,] CreateMatrix(int row, int colum, int min, int max) 
// // { 
// //     double[,] matr = new double[row, colum]; 
// //     Random rnd = new Random(); 
// //     for (int i = 0; i < matr.GetLength(0); i++) 
// //     { 
// //         for (int j = 0; j < matr.GetLength(1); j++) 
// //         { 
// //             matr[i, j] = rnd.NextDouble() * (max - min) + min; 
// //             matr[i, j] = Math.Round(matr[i, j], 1); 
// //         } 
// //     } 
// //     return matr; 
// // } 

int[,] array2D = RandomMatrix(3, 4, 0, 10);
PrintMatrix(array2D, "|", "|");