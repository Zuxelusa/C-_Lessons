/*

int FindQuadrant(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (-x > 0 && y > 0) return 2;
    if (-x > 0 && -y > 0) return 3;
    if (x > 0 && -y > 0) return 4;
    return 0;
}


Console.Write("Input X coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Y coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuadrant(xA, yA);
Console.WriteLine($"Your coordinate is {quadrant}");

*/

//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*

void isQuadrant(int N)
{
    if(N == 1) Console.WriteLine($"В {N} четверти X - положительные и Y - положительные.");
    if(N == 2) Console.WriteLine($"В {N} четверти X - отрицательные и Y - положительные.");
    if(N == 3) Console.WriteLine($"В {N} четверти X - отрицательные и Y - отрицательные.");
    if(N == 4) Console.WriteLine($"В {N} четверти X - положительные и Y - отрицательные.");
    if (N <1 || N > 4) Console.WriteLine($"Введите существующий номер четверти.");
}

Console.Write("Input number of quadrant: ");
isQuadrant(Convert.ToInt32(Console.ReadLine()));

*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void Qrt(int N)
{
    int count = 0;
    while (count < N)
    {
        int temp = count * count;
        Console.Write(temp + " ");
        count++;
    }
};

Console.Write("Input number: ");
Qrt(Convert.ToInt32(Console.ReadLine()));

*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double LengthBetweenDots(double xA, double yA, double xB, double yB)
{
    double xCat = xB - xA;
    double yCat = yB - yA;
    return Math.Sqrt(xCat * xCat + yCat * yCat);
}


Console.Write("Input X of Dot 1 coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Y of Dot 1 coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input X of Dot 2 coordinate: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Y of Dot 2 coordinate: ");
double yB = Convert.ToDouble(Console.ReadLine());

double Len = LengthBetweenDots(xA, yA, xB, yB);
Console.WriteLine($"Length of your line is: {Len}.");


