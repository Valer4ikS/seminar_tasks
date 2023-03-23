/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

using System;
using static System.Console;

Clear();

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int range = Prompt("Введите диапазон: от 1 до ");

int[,] array = GetArray(rows, columns, 0, range);

PrintArray(array);
WriteLine($"Минимальная сумма элементов в строке {FindMinRow(array)} ");
// PrintArray(array);

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
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, range + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} \t");
        }
        WriteLine();
    }
}

int FindMinRow(int[,] inArray)
{
    int sum = 0;
    int minSum = 0;
    int minRow = -1; // для себя
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        if (sum < minSum || minSum == 0)
        {
            minSum = sum;
            sum = 0;
            minRow = i;
        }

    }
    return minRow + 1; // для пользователя

}