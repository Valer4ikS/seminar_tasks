/* Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

using static System.Console;
Clear();


int m = Prompt("Введите неотрицательное число M: ");
int n = Prompt("Введите неотрицательное число N: ");
if (n > 0 && m > 0)
{
    WriteLine($"Функция Аккермана для A({m}, {n}) = {GetAkkerman(m, n)}");
}
else WriteLine($"n и m должны быть больше нуля! ");

int Prompt(string message)
{
    Write(message);
    return int.Parse(ReadLine()!);
}

int GetAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return GetAkkerman(m - 1, 1);
    else
        return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}
