// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечени которых расположен наименьший элемент

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

void MinRowColumn(int[,] matrix, out int indexrow, out int indexcolumn)
{
    int rows = matrix.GetLength(0);
    int colummns = matrix.GetLength(1);
    int min = matrix[0, 0];
    indexrow = 0;
    indexcolumn = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colummns; j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexcolumn = j;
                indexrow = i;
            }
        }
    }
}

int[,] RemoveRowColumMinEle(int[,] matrix, int indexrow, int indexcolumn)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] matrix2 = new int[rows - 1, columns - 1];
    for (int i = 0, m = 0; i < rows - 1; i++, m++)
    {
        if (m == indexrow) m++;
        for (int j = 0, n = 0; j < columns - 1; j++, n++)
        {
            if (n == indexcolumn) n++;
            matrix2[i, j] = matrix[m, n];
        }
    }
    return matrix2;
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
int RowMin, ColumnMin;
MinRowColumn(array2D, out RowMin, out ColumnMin);
int[,] newmatrix = RemoveRowColumMinEle(array2D, RowMin, ColumnMin);
Console.WriteLine();
PrintMatrix(newmatrix, "|", "|");