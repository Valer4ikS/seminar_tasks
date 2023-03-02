/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */


Console.Clear();
Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = GetArray(num);

int[] GetArray(int size)
{
    int[] res = new int[size];
    for(int i = 0; i< size; i++)
    {
        res[i] = new Random().Next(1, 20);
    }
    return res;
}


int SumOddInNum(int[] array)
{
    int sum = 0;
    int i = 1;
    while(i < array.Length)
    {   
        sum += array[i]; 
        i += 2;
    }
    return sum;
}


Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"{SumOddInNum(array)}");


