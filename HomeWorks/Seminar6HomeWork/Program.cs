//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
void PositiveCalc()
{
    Console.Write($"How many integers do you need to check: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Input {i+1} element: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 0) count++;
    }
    Console.Write($"Positive numbers quantity is {count}.");
}
PositiveCalc();
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Clear();
    Console.Write($"Lines with your coordinates cross at point (x={x},y={y}).");

    for (int i = 0; i < 20; i++)
    {
        y = k1 * i + b1;
        Console.SetCursorPosition(i, Convert.ToInt32(y));
        Console.Write("*");
        y = k2 * i + b2;
        Console.SetCursorPosition(i, Convert.ToInt32(y));
        Console.Write("*");

    }
}
//задаем систему координат

void MakeCoordinate(int From, int To)
{
    Console.Clear();
    for (int i = 0; i <= 20; i++)
    {
        Console.SetCursorPosition(i + From, To);
        Console.Write("|");
    }

    for (int j = 0; j <= 20; j++)
    {
        Console.SetCursorPosition(From, j + To);
        Console.Write("-");
    }

}
/*


*/

MakeCoordinate(10, 10);

//IntersectionPoint(5, 2, 9, 4);

