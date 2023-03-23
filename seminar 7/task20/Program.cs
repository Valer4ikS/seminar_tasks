/* Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> такого числа в массиве нет

*/

using System;
using static System.Console;

Clear();

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");

int rowsNum = Prompt("Введите номер строки: ");
int elNum = Prompt("Введите номер элемента строки: ");


int[,] array = GetArray(rows, columns, 0, 20);

PrintArray(array);

if (rowsNum > array.GetLength(0) || elNum > array.GetLength(1))
{
    WriteLine("такого элемента нет");
}
else
{
    WriteLine($"Значение элемента {rowsNum} строки и {elNum} столбца равно {array[rowsNum-1,elNum-1]}");
}

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
            result[i, j] = new Random().Next(min, max + 1);
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
            Write($"{inArray[i, j]} \t ");
        }
        WriteLine();
    }
}





