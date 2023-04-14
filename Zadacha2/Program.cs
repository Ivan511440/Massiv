// Задайте двумерный массив.
// Найдите элементы, у которых индексы четные,
// изамените эти элементы на их квадраты.

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 2 3 4

using System;
using static System.Console;

Clear();

Write("Введите количество строк в массиве: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
ChangeArray(array);
PrintArray(array);
WriteLine();
PrintArray(ChangeArray(array));
WriteLine();
PrintArray(array);
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 1; i < m; i++)
    {
        for (int j = 1; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }
    }
    return result;
}

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]}");
        }
        WriteLine();
    }
}




