/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18   */
using System;
using static System.Console;

Clear();


int rows1 = Prompt("Введите количество строк первого массива массива: ");
int columns1 = Prompt("Введите количество столбцов второго массива: ");
// int range = Prompt("Введите диапазон: от 1 до ");
int rows2 = Prompt("Введите количество строк массива: ");
int columns2 = Prompt("Введите количество столбцов массива: ");

int[,] array1 = GetArray(rows1, columns1, 0, 10);
int[,] array2 = GetArray(rows2, columns2, 0, 10);
PrintArray(array1);
WriteLine();
PrintArray(array2);
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
    for(int i = 0; i < m; i++)
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
    for(int i = 0; i< inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} \t");
        }
        WriteLine();
    }
}




