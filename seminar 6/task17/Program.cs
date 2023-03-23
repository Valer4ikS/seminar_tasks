/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */


int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int num = Convert.ToInt32(value);
    return num;
}

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Promt($"Введите {i + 1} число: ");
    }
    return array;
}

void PrintArray(int[] inArray)
{
    Console.WriteLine($"[{string.Join(", ", inArray)}]");
}

int CountAboveZero(int[] m)
{
    int count = 0;
    
    for (int i = 0; i < m.Length; i++)
    {
        if (m[i] > 0)
            count++;
    }
    return count;
}

int count = Promt("Кол-во чисел: ");
int[] array;
array = GetArray(count);
PrintArray(array);
Console.WriteLine($"{CountAboveZero(array)}");

