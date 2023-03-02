/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */


Console.Clear();

double[] NewArray = { 15, 7, 11, 7, 66, 65, 51, 43, 14, 4 };

double GetDifferent(double[] array)
{
    double max = array[0];
    double min = array[0];
    foreach (double el in array)
    {
        if (el > max) max = el;
        if (el < min) min = el;
    }
    double result = max - min;
    return result;
}

Console.WriteLine($"[{string.Join(" ", NewArray)}] -> {GetDifferent(NewArray)}");