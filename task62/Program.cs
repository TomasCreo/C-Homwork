// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] RandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= rows * columns)
    {
        matrix[i, j] = num;
        if (i <= j + 1 && i + j < rows - 1)
            ++j;
        else if (i < j && i + j >= columns - 1)
            ++i;
        else if (i >= j && i + j > columns - 1)
            --j;
        else
            --i;
        ++num;
        
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


int stringsize = 0;
int columsize = 0;

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
