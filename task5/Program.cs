// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введите любое число: ");
// int a = int.Parse(Console.ReadLine()!);
// if (a <= 99)
// {
//     Console.WriteLine("Число меньше 100");
// }
// else
// {
//     while (a > 999)
//     {
//         a = a / 10;
//     }
//     Console.WriteLine(a % 10);
// }



// задача 2

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while( number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Promt("Введите число: ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}