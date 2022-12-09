// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] firstmatrix, int[,] secondmatrix, int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < firstmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondmatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < firstmatrix.GetLength(1); k++)
            {
                resultMatrix[i, j] = resultMatrix[i, j] + firstmatrix[i, k] * secondmatrix[k, j];
            }
        }
    }
    return resultMatrix;
}

int stringsize = 0;
int columsize = 0;
int stringsize2 = 0;
int columsize2 = 0;

while (stringsize <= 0 || columsize <= 0 || stringsize2 <= 0 || columsize2 <= 0)
{
    Console.WriteLine($"Введите количество сторок первой матрицы");
    stringsize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите количество столбцов первой матрицы");
    columsize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите количество сторок второй матрицы");
    stringsize2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите количество столбцов второй матрицы");
    columsize2 = Convert.ToInt32(Console.ReadLine());
    if (stringsize <= 0 || columsize <= 0 || stringsize2 <= 0 || columsize2 <= 0)
        Console.WriteLine("Введены неверные данные");
}
int[,] array2D = RandomMatrix(stringsize, columsize, 0, 9);
int[,] secondArray2D = RandomMatrix(stringsize2, columsize2, 0, 9);
PrintMatrix(array2D, "|", "|");
Console.WriteLine();
PrintMatrix(secondArray2D, "|", "|");
Console.WriteLine();
if (columsize == stringsize2)
{
    int [,] resultMatrix = MatrixMultiplication(array2D, secondArray2D, stringsize, columsize2);
    PrintMatrix(resultMatrix, "|", "|");
}
else Console.WriteLine("Умножение не возможно");