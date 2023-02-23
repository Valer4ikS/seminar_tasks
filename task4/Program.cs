// Задача 13. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int numt= 0;
if (num < 100)
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}

else
{
    numt = num;
    while (numt > 999)
    {
        numt = numt / 10;
    }
    Console.WriteLine($"{num} -> {numt % 10}");
}



// ?????
// Console.WriteLine("Введите трехзначное число: ");
//     while(true)
//     {
//         string input = Console.ReadLine();
//         if(!input.Equals("exit"))
//             Console.WriteLine("{0}->{1}",input, input[1]);
//         else
//             break;
//     } 



// int Promt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine()!;
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int number = Promt("Введите трехзначное число > ");
// if (number < 100 || number > 1000)
// {
//     Console.WriteLine("Вы ввели не трехзначное число, повторите ввод");
//     return;
// }



// Console.WriteLine($"Введенное число '{number}'");
// int secondRank = number / 10;
// Console.WriteLine($"{secondRank} -> {secondRank% 10}");


// Console.Clear();
// Console.Write("Введи трёхзначное число: ");
// int threedigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threedigitNumber);
// // Console.WriteLine
// Console.WriteLine("вторая цифра этого числа ->" + stringNumber[1]);

