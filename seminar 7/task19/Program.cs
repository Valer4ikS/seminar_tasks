/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9      

*/

using System;
using static System.Console;

Clear();

int rows = Prompt("Введите количество строк массива: "); // int.Parse
int columns = Prompt("Введите количество столбцов массива: "); // int.Parse

// double[,] array = new double[rows, columns];
double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

int Prompt(string message)
{
    Write(message);
    int num = int.Parse(ReadLine()!);
    return num;
}

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for(int i = 0; i< m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(min, max + 1)) / 10;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    
    for(int i = 0; i< inArray.GetLength(0); i++)
    {
        // Write("[");
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} \t");
        }
        // Write("]");
        WriteLine();
    }
}