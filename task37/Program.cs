// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string symb1, string symb2)
{
    Console.Write(symb1);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(symb2);
}

Console.Write("Введите кол-во элементов массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(sizeArray, 1, 9);
PrintArray(array, "[", "]");

int[] MultArray(int[] arr)
{
    int[] arr1 = arr.Length % 2 == 0 ? new int[arr.Length / 2]
                                    : new int[arr.Length / 2 + 1];
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 == 1) arr1[arr1.Length - 1] = arr[arr.Length / 2];
    return arr1;
}

int[] array2 = MultArray(array);
PrintArray(array2, " -> ", "");

// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] arr = new double[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.NextDouble() * (max - min) + min;
//     }
//     return arr;
// }

