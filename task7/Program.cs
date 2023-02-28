// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// 1 Чет не работает

Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a]; // a
if (array[0] == array[4] && array[1] == array[3])
{
    Console.Write("число является палиндромом");
}
else Console.Write("число не является палиндромом");


// 2 

// Console.Write("Введите пятизначное число: ");
// int a = int.Parse(Console.ReadLine()!);
// int temp = a;
// int rev = 0; // обратная a
// while (a > 0)
// {
//     int b = a % 10;
//     rev = rev * 10 + b;
//     a = a / 10;
// }
// if (temp == rev)
// {
//     Console.Write("число является палиндромом");
// }
// else Console.Write("число не является палиндромом");

