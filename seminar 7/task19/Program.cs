/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9      

*/

using System;
using static System.Console;

Clear();

// Write("Введите количество строк массива: ");
int rows = Prompt("Введите количество строк массива: "); // int.Parse(ReadLine()!);
// Write("Введите количество столбцов массива: ");
int columns = Prompt("Введите количество столбцов массива: "); // int.Parse(ReadLine()!);

double[,] array = new double[rows, columns];
// double[,] array = GetArray(rows, columns, -10, 10);
GetArray(array);
PrintArray(array);

int Prompt(string message)
{
    Write(message);
    int num = int.Parse(ReadLine()!);
    return num;
}

void GetArray(double[,] inArray)
{
    // double[,] result = new double[m, n];
    for(int i = 0; i< inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    // return result;
}

void PrintArray(double[,] inArray)
{
    for(int i = 0; i< inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} \t ");
        }
        WriteLine();
    }
}