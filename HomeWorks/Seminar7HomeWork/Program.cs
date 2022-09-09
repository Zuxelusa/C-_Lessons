// Метод для создания 2-х мерного массива случайных чисел с запросом размерности
int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

// Метод вызывающий дублирование строкового элемента, указанное количество раз.
string RepeatString(string text, int q)
{
    string str = String.Empty;
    for (int i = 0; i < q; i++) str += text;
    return str;
}

// Метод для вывода матрицы 2 мерного массива c возможностью выбора параметра выравнивания выводимой матрицы
void Show2dArray(int[,] array, bool needAlign)
//void Show2dArray(double[,] array, bool needAlign)
{
    int lengthOfMax = 0;
    string curCell = String.Empty;
    if (needAlign)
    {
        // Цикл, который определяет самую длинную строку в массиве
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                string current = Convert.ToString(array[i, j]);
                if (current.Length > lengthOfMax) lengthOfMax = current.Length;
            }
    }

    // Цикл, выводящий массив
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (needAlign) curCell = Convert.ToString(array[i, j]);
            Console.Write(array[i, j] + RepeatString(" ", lengthOfMax - curCell.Length + 1));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод для вывода 1D матрицы
void PrintArray(double[] arr)
{
    string str = " | ";
    for (int i = 0; i < arr.Length; i++)
    {   
        if (i + 1 == arr.Length) str = "";
        Console.Write(arr[i] + str);
    }
}

// Метод для генерации случайного вещественного числа в заданном диапазоне и округлением после запятой
double GenerateRandomDouble(int from, int to, int roundParam)
{
    int valueInt = new Random().Next(from, to);
    double valueDouble = new Random().NextDouble();
    return Math.Round(valueInt + valueDouble, roundParam);
}

// Метод для проверки, имеется ли в 2D массиве элемент по указанному адресу
bool isElementAddress(int[,] array, int row, int col)
{
    if (row <= array.GetLength(0) && col <= array.GetLength(1)) return true;
    else return false;
}

// Метод, генерирующий 2 мерный массив вещественных чисел, использует метод GenerateRandomDouble
double[,] CreateRandom2dArrayInDouble(int roundValue)
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = GenerateRandomDouble(minValue, maxValue, roundValue);

    return array;
}

// Метод, который выводит среднее арифметическое по столбцам 2D массива
double[] AverageForColumns2dArray(int[,] array, int roundParam)
{
    double[] arr = new double[array.GetLength(1)];
    double sum;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
            sum += array[j, i];
        arr[i] = Math.Round(sum / array.GetLength(0), roundParam);
    }
    return arr;
}

/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("-----PROGRAM FOR 2D ARRAY OUTPUT (IN DOUBLE DATA TYPE)-----");
Console.WriteLine();
Show2dArray(CreateRandom2dArrayInDouble(4), true);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*
// Запрос данных
Console.Clear();
Console.WriteLine("-----PROGRAM FOR CHECKING ELEMENT IN 2D ARRAY-----");
Console.WriteLine();
int[,] array = CreateRandom2dArray();
Console.Write("Input row number of element to find: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column number of element to find: ");
int column = Convert.ToInt32(Console.ReadLine());

// Вывод результатов
Show2dArray(array, true);
Console.WriteLine();
if (isElementAddress(array, row, column)) Console.WriteLine($"Element with address ({row},{column}) is in 2D array with size ({array.GetLength(0)},{array.GetLength(1)}) and has value is {array[row - 1, column - 1]}.");
else Console.WriteLine($"There is no element with address ({row},{column}) in 2D array with size ({array.GetLength(0)},{array.GetLength(1)}).");
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
Console.Clear();
Console.WriteLine("-----PROGRAM FOR CALCULATING AVERAGE BY COLUMNS IN 2D ARRAY-----");
Console.WriteLine();

int[,] array = CreateRandom2dArray();
double[] resultArray = new double[array.GetLength(1)];
Console.WriteLine();
Show2dArray(array, true);
Console.Write($"The average values for columns: [");
PrintArray(AverageForColumns2dArray(array, 2));
Console.WriteLine("].");
*/