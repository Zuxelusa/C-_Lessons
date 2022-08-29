// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
double Degree(double a, int b, int rou)
{
    double sum = 1;
    for (int i = 1; i <= b; i++)
        sum *= a;
    return Math.Round(sum,rou);
}

Console.Write("Input the number: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the degree: ");
int deg = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the number of decimal places: ");
int qua = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The {deg} degree of {num} is {Degree(num, deg, qua)}.");
*/
/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*

int SumOfDigits(double n)
//Метод строковый, который считает сумму цифр, любого числа, даже дробных (с запятой)
{
    string num = Convert.ToString(n);
    num = num.Replace(",", "");
    int sum = 0;

    for (int i = 0; i < num.Length; i++)
        sum += Convert.ToInt32(num.Substring(i, 1));
    return sum;
}
*/

int SumOfDigits(int n)
//Метод математический, который считает сумму цифр числа типа Int32
{
    int sum = 0;
    while (n > 0)
    {        
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

Console.Write("Input the number: ");
//double num = Convert.ToDouble(Console.ReadLine());
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Sum of digits of {num} is {SumOfDigits(num)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
void PrintArray(int[] arr)
{
    if (arr.Length != 0)
    {
    string comma = "";
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i > 0) comma = ", ";
        Console.Write(comma + arr[i]);
    }
    Console.Write("]");
    }
    else Console.Write("empty");
}

Console.Write("Array size is: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];
for (int j = 0; j < num; j++)
{
    Console.Write($"Input content for {j} index: ");
    array[j] = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"Your array is ");
PrintArray(array);
*/