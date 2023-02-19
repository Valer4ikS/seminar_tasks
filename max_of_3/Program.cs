Console.Write("Первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Третье число: ");
int c = int.Parse(Console.ReadLine()!);
if (a > b & a > c & b > c)
{
    Console.WriteLine("Максимальное число " + a);
    Console.WriteLine(" Минимальное число " + c);
}
else if (b > a & b > c & c > a)
{
    Console.WriteLine("Максимальное число " + b);
    Console.WriteLine(" Минимальное число " + a);
}
else if (a > c)
{
    Console.WriteLine("Максимальное число " + b);
    Console.WriteLine(" Минимальное число " + c);
}

















