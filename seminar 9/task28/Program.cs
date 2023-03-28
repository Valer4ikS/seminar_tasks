/* Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;
using static System.Console;

Clear();

int n = Prompt("Введите значение N: ");
int m = Prompt("Введите значение M: ");

if (n > m)
{
    int k = m;
    m = n;
    n = k;
}

WriteLine($"Сумма элементов от {n} до {m} = {GetNaturalSum(n, m)}");

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(ReadLine()!);
}

int GetNaturalSum(int n, int m)
{
    if (m == n)
        return n;
    return n + GetNaturalSum(n + 1, m);
}

