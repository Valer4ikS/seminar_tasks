// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (a > b)
{
    if (a > c)
        max = a;
    else
        max = c;
}
if (b > a)
{
    if (b > c)
        max = b;
    else
        max = c;
}

Console.WriteLine("Максимальное число: " + max);