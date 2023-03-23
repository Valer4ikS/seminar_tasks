/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

// первый вариант

// Console.WriteLine("Введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"Прямые пересекаются по координатам X: {x}, Y: {y}");


//

int X = 0;
int Y = 1;
int K = 0;
int B = 1;

int Line1 = 1;
int Line2 = 2;

double[] line1 = GetLineData(Line1);
double[] line2 = GetLineData(Line2);

double Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    double result = Convert.ToDouble(value);
    return result;
}

double[] GetLineData(int line)
{
    double[] linedata = new double[2];
    linedata[K] = Prompt($"Введите коэффициент для прямой {line}: ");
    linedata[B] = Prompt($"Введите константу для прямой {line}: ");
    return linedata;
}

double[] GetCrossCoords(double[] line1, double[] line2)
{
    double[] coordinate = new double[2];
    coordinate[X] = (line1[B] - line2[B]) / (line2[K] - line1[K]);
    coordinate[Y] = line1[B] * coordinate[X] + line1[B];
    return coordinate;
}

if (ValidateLines(line1, line2))
{
    double[] coordinate = GetCrossCoords(line1, line2);
    Console.Write($"y={line1[K]}*x+{line1[B]} и y={line2[K]}*x+{line2[B]} ");
    Console.WriteLine($"пересекаются по координатам ({coordinate[X]}, {coordinate[Y]})");
}

bool ValidateLines(double[] line1, double[] line2)
{
    if (line1[K] == line2[K])
    {
        if (line1[B] == line2[B])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else{
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

