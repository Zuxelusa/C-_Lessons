int[] CreateRandomArray(int size, int MinValue, int MaxValue)
{
    int[] NewArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        NewArray[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return NewArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    //Console.WriteLine();
}
void PrintDArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    //Console.WriteLine();
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
Console.Write($"Input the size of array: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateRandomArray(N, 100, 999);

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0) count++;
}

Console.Write($"The quantity of EVEN integers in array: [");
PrintArray(arr);
Console.Write($"] is {count}. This is {count * 100 / arr.Length}% of array.");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
Console.Write($"Input the size of array: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateRandomArray(N, -10, 20);

int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0) sum += arr[i];
}

Console.Write($"The sum of elements in ODD indexes of array: [");
PrintArray(arr);
Console.Write($"] is {sum}.");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double FindMinMax(double[] arr, int param)
{
    double max = arr[0], min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    if (param == 0) return min;
    if (param == 1) return max;
    return 0;
}

Console.Write($"Input the size of array: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateRandomArray(N, -10, 10);
double[] dArr = new double[arr.Length];
double rand = 0;

//Производим перевод случайного массива в DOUBLE
for (int i = 0; i < arr.Length; i++)
{
    rand = new Random().NextDouble();
    dArr[i] = Math.Round(arr[i] + rand, 4);
}

double max = FindMinMax(dArr, 1);
double min = FindMinMax(dArr, 0);
Console.Write($"In array: ");
PrintDArray(dArr);
Console.Write($". The difference between {max} and {min} is {max - min}");
