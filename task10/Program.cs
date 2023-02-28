// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);
// double result = Math.Pow(a, b);

int MathPow (int a, int b)
{
    int res = 1;
    for(int i = 0; i < b; i++){
        res *= a;
    }
        return res;
}

bool ValidExp(int b)
{
    if(b < 0){
    Console.WriteLine("Степень меньше нуля");
    return false;
    }
    return true;

}
if (ValidExp(b))
    Console.Write($"{MathPow(a, b)}");