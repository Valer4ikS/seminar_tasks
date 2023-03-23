/* Задача 60. ...
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/
using System;
using static System.Console;

Clear();

int a = Prompt("Введите размерность матриц: ");
int b = Prompt("Введите размерность матриц: ");
int c = Prompt("Введите размерность матриц: ");

int[,,] array = GetArray(a, b, c, 0, 5);
WriteLine("Трехмерный массив");
PrintArray(array);
WriteLine();
WriteLine();


int Prompt(string message)
{
    Write(message);
    int num = int.Parse(ReadLine()!);
    return num;
}

int[,,] GetArray(int m, int n, int c, int min, int max)
{
    int[,,] result = new int[m, n, c];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            for(int k = 0; k < c; k++)
            {
            result[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for(int i = 0; i< inArray.GetLength(0); i++)
    {
        Write("[ ");
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
                for(int k = 0; k < inArray.GetLength(2); k++)
                {
                    Write($"{inArray[i, j, k]} ");
                }
        }
        Write("]");
        WriteLine();
    }
}