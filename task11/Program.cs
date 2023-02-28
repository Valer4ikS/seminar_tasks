// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
// int[] array = new int[a];

int DigitSum(int s)
{
    int sum = 0;
    if (s < 0)
        s *= (-1);
    while (s > 0)
    {
        sum += s % 10;
        s /= 10;
    }
    return sum;
}



Console.Write($"{DigitSum(a)}");