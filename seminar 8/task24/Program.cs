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


int a = Prompt("Введите размерность матриц: ");


int[,] array1 = GetArray(a, a, 0, 10);
int[,] array2 = GetArray(a, a, 0, 10);
WriteLine("Первая матрица");
PrintArray(array1);
WriteLine();
WriteLine("Вторая матрица");
PrintArray(array2);
WriteLine();
WriteLine("Финальная матрица");
PrintArray(GetMultiArray(array1, array2));
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
        Write("[ ");
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        Write("]");
        WriteLine();
    }
}


int[,] GetMultiArray(int[,] inArray1, int[,] inArray2)
{
    int multiRow = inArray1.GetLength(0);
    int multiColumns = inArray2.GetLength(1);
    int arr1Columns = inArray1.GetLength(1);

    int[,] multiArray = new int[multiRow, multiColumns];

    for(int i = 0; i < multiRow; i++)
    {
        for(int j = 0; j < multiColumns; j++)
        {
            for(int k = 0; k < arr1Columns; k++)
            {
                {
                    multiArray[i, j] += inArray1[i, k] * inArray2[k, j];
                }
            }
        }
    }
    return multiArray;
}

// int[,] GetMultiArray(int[,] inArray1, int[,] inArray2)
// {
//     int   
//     int   
//     int[,] multiArray = new int[sizeR, sizeC];
//     for(int i = 0; i < inArray1.GetLength(0); i++)
//     {
//         for(int j = 0; j < inArray1.GetLength(1); j++)
//         {
//             for(int k = 0; k < inArray2.GetLength(0); k++)
//             {
//                 for(int r = 0; r < inArray2.GetLength(1); r++)
//                 {
//                     multiArray[sizeR, sizeC] +=
// }