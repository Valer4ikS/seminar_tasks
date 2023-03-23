/* Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.   */

using System;
using static System.Console;

Clear();

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
    {   
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
        average += array[i, j];
        }
        average = average / rows;
        Write(average + "; ");
    }
    
WriteLine();

int Prompt(string message)
{
    Write(message);
    int num = int.Parse(ReadLine()!);
    return num;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} \t ");
        }
        WriteLine();
    }
}


// double GetArithmeticalMean(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {   
//         double average = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//         average = (average + array[i, j]);
//         }
//         average = average / rows;
//         Write(average + "; ");
//     }
//     return average;
// }


