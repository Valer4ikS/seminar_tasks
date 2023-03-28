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

int a = Prompt("Введите 1 размерность матрицы: ");
int b = Prompt("Введите 2 размерность матрицы: ");
int c = Prompt("Введите 3 размерность матрицы: ");


int[,,] array = Get3DArray(a, b, c, 0, 5);
PrintArray(array);
WriteLine();


int Prompt(string message)
{
    Write(message);
    int num = int.Parse(ReadLine()!);
    return num;
}

int[,,] Get3DArray(int m, int n, int c, int min = 0, int max = 0)
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
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
                for(int k = 0; k < inArray.GetLength(2); k++)
                {
                    WriteLine($"{inArray[i, j, k]}({i},{j},{k})");
                    //2ой вариант вывода WriteLine($"({i},{j},{k}) - {inArray[i, j, k]}"); 
                }
        }
        // WriteLine();
    }
}

