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
/*
void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);
    Console.Write($"Lines of both functions y={k1}x+{b1} and y={k2}x+{b2} cross at point (x={x}, y={y}).");
}

IntersectionPoint(5, 2, 9, 4);
*/
