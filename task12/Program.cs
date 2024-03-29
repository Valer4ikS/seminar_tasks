﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int[] array = GetBinArray(num);

Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetBinArray(int size){
    int [] result = new int[size];
    for (int i =0; i < size; i++){
        result[i] = new Random().Next(0, 100);
    }
    return result;
}
