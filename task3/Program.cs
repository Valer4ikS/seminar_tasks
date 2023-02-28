// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];

void FillArray(int[] mas)
{
    int length = mas.Length;
    mas[0] = 1; // условие задачи
    int index = 1;
    while (index < length)
    {
        mas[index] = index + 1;
        index++;
    }
}

void PrintArray(int[] num)
{
    int count = num.Length;
    int position = 0;
    while (position < count)
    {
        position++;
    }
}

FillArray(array);
PrintArray(array);

int[] aray = array.Where(x => x % 2 == 0).ToArray();
Console.WriteLine(string.Join(", ", aray.Select(x => x.ToString())));

// 
