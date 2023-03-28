/* Задача 64: 
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

using System;
using static System.Console;

Clear();

Write("Введите число N: ");
int n = int.Parse(ReadLine()!);
int m = 1;

if(n < 1)
{
    WriteLine("Введите положительное число! ");
}

WriteLine();
WriteLine(PrintNumbers(n, m));

int PrintNumbers(int n, int m)
{
    if(n == m) return n;
    else Write($"{PrintNumbers(n, m + 1)} ");
    return m;
}