// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] RandomMatrix(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();
    int num = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

void RandomizeSameNums(int[,,] matrix)
{
    int num = matrix[0, 0, 0];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i,j,k] == num) matrix[i, j, k] = num +1;
                num = matrix[i,j,k];

            }
        }
    }
}

void PrintMatrix(int[,,] matrix, string sep1, string sep2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{sep1}");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 0) Console.Write($"{matrix[i, j, k],5} ({i}, {j}, {k})|");
                else Console.Write($"{matrix[i, j, k],5} ({i}, {j}, {k})");
            }
        }
        Console.WriteLine($"{sep2}");
    }
}

int[] ChangeToOneString(int[,,] matrix)
{
    int[] array = new int[matrix.Length];
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                array[n++] = matrix[i, j, k];
            }
        }
    }
    return array;
}

void CounterValue(int[] array)
{
    int count = 0;
    int num = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) count++;
        else 
        {
            Console.WriteLine($"{num} встречается {count} раз");
            count = 1;
            num = array[i];
        }
    }
    Console.WriteLine($"{num} встречается {count} раз");
}

int stringsize = 0;
int columsize = 0;
int depthsize = 0;

while (stringsize <= 0 || columsize <= 0 || depthsize <= 0)
{
    Console.WriteLine($"Введите количество сторок");
    stringsize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите количество столбцов");
    columsize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите глубину");
    depthsize = Convert.ToInt32(Console.ReadLine());
    if (stringsize <= 0 || columsize <= 0 || depthsize <= 0)
        Console.WriteLine("Введены неверные данные");
}
int[,,] array3D = RandomMatrix(stringsize, columsize, depthsize, 10, 99);
PrintMatrix(array3D, "|", "|");
Console.WriteLine("");
Console.WriteLine("разделитель");
RandomizeSameNums(array3D);
PrintMatrix(array3D, "|", "|");
int[] newarray = ChangeToOneString(array3D);
Array.Sort(newarray);
Console.WriteLine();
CounterValue(newarray);