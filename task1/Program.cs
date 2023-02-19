// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Третье число: ");
int c = int.Parse(Console.ReadLine()!);
int[] array = { a, b, c };
int i = 0;
int imax = 0;
int imin = 0;
while (i < 3)
    if (array[i] > array[imax])
    {
        imax = i;
    }
    else if (array[i] < array[imin])
    {
        imin = i;
    }

Console.WriteLine(" Максимальное число " + array[imax]);
Console.WriteLine(" Минимальное число " + array[imin]);
