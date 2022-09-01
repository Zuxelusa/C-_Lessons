//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

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
    Console.WriteLine();
}
/*
int FindNegSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

Console.Write("Input the size of array to sum negative integers: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("From: ");
int minv = Convert.ToInt32(Console.ReadLine());

Console.Write("To: ");
int maxv = Convert.ToInt32(Console.ReadLine());

int[] newArr = CreateRandomArray(size, minv, maxv);

Console.Write($"The sum of neg integers of array: ");
PrintArray(newArr);
Console.Write($" is:{FindNegSum(newArr)}.");
*/

//Напишите программу для замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] newArray = CreateRandomArray(12, -20, 20);
int[] nextArray = new int[newArray.Length];

for (int i = 0; i < newArray.Length; i++)
{
    nextArray[i] = newArray[i] * -1;
}

Console.WriteLine("Your start array: ");
PrintArray(newArray);

Console.WriteLine("Your next array: ");
PrintArray(nextArray);
*/
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
bool isThere (int N, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == N) return true;
    }
    return false;
}

int[] newArray = CreateRandomArray(12, -20, 20);
Console.Write($"Input the integer to search: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"In your array: ");
PrintArray(newArray);
Console.Write($"The {N} integer status in {isThere(N, newArray)} ");
*/

//Задайте одномерный массив из 15 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int[] newArray = CreateRandomArray(15, -40, 150);

int InRange(int[] newArray, int From, int To)
{
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] > From & newArray[i] < To)
        {
            count++;
        }
    }
    return count;
}
Console.Write($"In your array: ");
c
Console.Write($"Quantity integers of range is {InRange(newArray, 10, 99)}.");
*/

//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
/*
int[] arr = CreateRandomArray(8, 5, 10);

int[] newArray = new int[arr.Length / 2 + arr.Length % 2];

for (int i = 0; i < arr.Length / 2 + arr.Length % 2; i++)
{
    newArray[i] = arr[i] * arr[arr.Length - i - 1];
}
Console.Write($"The multiplication array of:");
PrintArray(arr);
Console.WriteLine($"is");
PrintArray(newArray);
*/
