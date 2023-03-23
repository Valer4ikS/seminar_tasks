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

PrintArray(array);
WriteLine();
int[] roWar = GetRowArray(array);
SortArray(roWar);
WriteLine(String.Join(" ", roWar));
PrintArray(array);
GetDualArray(roWar);


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

int[] GetRowArray(int[,] inArray) // метод принимает на вход двумерный массив и возвращает одномерный
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)]; // длина одномерного массива = строки * столбцы
    int index = 0; // переменная для обращения к массиву result
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i, j]; 
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray) // пузырьковая сортировка, двигаем тяжелые элементы вправо
{
    for (int i = inArray.Length - 1; i > 0; i--) // 
    {
        for (int j = inArray.Length - 1; j > 0; j--) // i + 1, потому что появляется часть, которую не нужно перебирать еще раз
        {
            if (inArray[i] < inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

int[,] GetDualArray(int[] inArray) // метод принимает на вход одномерный массив и возвращает двумерный
{
    int[,] result = new int[inArray.Length]; // длина одномерного массива = строки * столбцы
    int index = 0; // переменная для обращения к массиву result
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[i, j] = inArray[i, j];
            index++;
        }
    }
    return result;
}

// int[,] PrintData(int[] inArray)
// {
//     int el = inArray[0]; // стартуем с первого элемента
//     int count = 1; // считаем, что одно значени уже встретилось 1 раз
//     for(int i = 0; i < inArray.Length; i++) // стартуем цикл со второго элемента
//     {
//         if(inArray[i] != el) //если текущее число не равно предыдущему, то выводим, что предыдущее число встретилось count раз
//         {
//             WriteLine($"{el} встречаются {count} раз ");
//             el = inArray[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
// }