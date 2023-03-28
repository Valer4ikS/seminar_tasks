/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07    */


// вариант из сети

using System;
using static System.Console;

Clear();

WriteLine("Введите размер массива");
int size = Convert.ToInt32(ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        Write("]");
        WriteLine("");
    }
}

// int a = Prompt("Введите длину строк массива: ");
// // int columns = Prompt("Введите длину столбцов массива: ");

// int[,] array = GetArray(a, a, 0, 5);

// PrintArray(array);
// WriteLine();

// int Prompt(string message)
// {
//     Write(message);
//     int num = int.Parse(ReadLine()!);
//     return num;
// }

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j] +3} ");
//         }
//         WriteLine();
//     }
// }


