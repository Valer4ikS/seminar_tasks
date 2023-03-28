/* Задача 54: 
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2    */

using System;
using static System.Console;

Clear();


int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int range = Prompt("Введите диапазон: от 1 до ");

int[,] array = GetArray(rows, columns, 0, range);

WriteLine("Исходный массив ");
PrintArray(array);
WriteLine();


// не получилось методом
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
        {
            if (array[i, z] < array[i, z + 1]) 
            {
                int temp = 0;
                temp = array[i, z];
                array[i, z] = array[i, z + 1];
                array[i, z + 1] = temp;
            }
        }
    }
}

WriteLine("Массив с элементами по убыванию в каждой строке ");
PrintArray(array);

int Prompt(string message)
{
    Write(message);
    int num = int.Parse(ReadLine()!);
    return num;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, range + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i< inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} \t");
        }
        WriteLine();
    }
}

// // двумерный массив в одномерный
// int[] GetRowArray(int[,] inArray) 
// {
//     int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)]; 
//     int index = 0; // переменная для result
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             result[index] = inArray[i, j]; 
//             index++;
//         }
//     }
//     return result;
// }

// // пузырьковая сортировка на убывание
// void SortArray1(int[] inArray) 
// {
//     for (int i = inArray.Length - 1; i > 0; i--) 
//     {
//         for (int j = inArray.Length - 1; j > 0; j--) 
//         {
//             if (inArray[i] < inArray[j]) 
//             {
//                 int k = inArray[i];
//                 inArray[i] = inArray[j];
//                 inArray[j] = k;
//             }
//         }
//     }
// }



// int[,] SortArray2(int[,] inArray) 
// {
//     int[,] res = new int[inArray.GetLength(0), inArray.GetLength(1)];
//     for (int i = 0; i < inArray.GetLength(0) - 1; i++) // 
//     {
//         for (int j = 0; i < inArray.GetLength(1) - 1; j++) // i + 1, потому что появляется часть, которую не нужно перебирать еще раз
//         {
//             for(int k = 0; k < inArray.GetLength(1) - 1; k++)
//             {
//                 if (inArray[i, k] < inArray[i, k + 1])
//                 {
//                     // int r = 0;
//                     res[i, j] = inArray[i, k];
//                     inArray[i, k] = inArray[i, k + 1];
//                     inArray[i, k + 1] = res[i,];
//                 }
//             }
//         }
//     }
//     return inArray;
// }

