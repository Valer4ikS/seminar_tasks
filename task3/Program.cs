// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число: n ");
int a = int.Parse(Console.ReadLine());
int i = 2;
while (i <= n)
{
    Console.Write(i);
    if (i < n - 1) { Console.Write(", ")}
    i += 2;
}




// i = 2;
// while (i<=n) 
// {
// Console.Write(i);
// if (i < n-1) { Console.Write(", ") };
// i +=2;
// }


// int i = 2;
// while (i <= n)
// {
//     if mas[i] % 2 == 0;
// }