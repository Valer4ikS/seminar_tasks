// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);
if (num >= 1 && num < 6)
{
    Console.WriteLine($"{num} -> Не выходной");
}

if (num > 5 && num <= 7)
{
    Console.WriteLine($"{num} -> Выходной");
}

else
{
    Console.WriteLine("Число не может быть днем недели");
    Console.WriteLine("Значение должно быть от 1 до 7");
}

// int Method3()
// {
//     return DateTime.Today.DayOfWeek;
// }

// int day =  Method3();
// Console.WriteLine(day);

// Вид 4 - методы, которые что-то принимают и что-то возвращают


// string Method4(int count, string text) // строку text компануем count раз
// {
//     int i = 0;
//     string result = String.Empty; // String.Empty  

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "efe");
// Console.WriteLine(res);