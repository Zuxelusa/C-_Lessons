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
            // Console.Write(array[i, j] + RepeatString(" ", lengthOfMax - curCell.Length + 1));
            Console.Write(RepeatString(" ", lengthOfMax - curCell.Length + 1) + array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Show2dArrayString(string[,] array, bool needAlign)
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
            // Console.Write(array[i, j] + RepeatString(" ", lengthOfMax - curCell.Length + 1));
            Console.Write(RepeatString(" ", lengthOfMax - curCell.Length + 1) + array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

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

// Метод для создания 3-х мерного массива случайных чисел с запросом размерности и параметра уникальности элементов. 
// При недостаточности места для генерируемых чисел выводится пустой массив
int[,,] CreateRandom3dArray(bool unique)
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int depths = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,] newArray = new int[rows, columns, depths];

    if ((unique) && (rows * columns * depths > maxValue - minValue - 1)) return newArray;
    else
    {
        int temp = 0;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
                for (int k = 0; k < depths; k++)
                {
                    if (unique)
                    {
                        do temp = new Random().Next(minValue, maxValue + 1);
                        while (isFoundIn3dArray(newArray, temp) != false);
                        newArray[i, j, k] = temp;
                    }
                    else newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
                }
    }
    return newArray;
}

// Метод добавляет в 3d массиве к элементам их адреса
string[,,] AddIndexesTo3dArrayElements(int[,,] array)
{
    string[,,] strArray = new string[array.GetLength(0), array.GetLength(2), array.GetLength(2)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                strArray[i, j, k] = array[i, j, k] + $"({i},{j},{k})";
    return strArray;
}

// Метод, проверяющий наличие проверяемого элемента в 3d массиве
bool isFoundIn3dArray(int[,,] array, int N)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (array[i, j, k] == N) return true;
    return false;
}

//Метод вывода 3d массива в виде последовательных 2d массивов
void Show3dArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        int[,] tempLayer = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                tempLayer[i, j] = array[i, j, k];
        Show2dArray(tempLayer, true);
        Console.WriteLine();
    }
}

void Show3dArrayString(string[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        string[,] tempLayer = new string[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                tempLayer[i, j] = array[i, j, k];
        Show2dArrayString(tempLayer, true);
        Console.WriteLine();
    }
}

// Метод сортировки 1D массива c параметром sortBy типа bool, true - сортировка по возрастанию, false - сортировка по убыванию.
int[] Sort1dArray(int[] array, bool sortBy)
{
    int N = array.Length, temp;
    for (int i = 0; i < N; i++)
        for (int j = 0; j < N - i - 1; j++)
            if (array[i] < array[i + j + 1] != sortBy)
            {
                temp = array[i + j + 1];
                array[i + j + 1] = array[i];
                array[i] = temp;
            }
    return array;
}

// Метод сортировки 2D массива c параметром sortBy типа bool, true - сортировка по возрастанию, false - сортировка по убыванию.
int[,] Sort2dArray(int[,] array, bool sortBy)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] curArr = new int[array.GetLength(1)];
        // считываем строку, пропускаем через сортировку, записываем в строку 2D массива
        for (int j = 0; j < array.GetLength(1); j++)
            curArr[j] = array[i, j];
        Sort1dArray(curArr, sortBy);
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = curArr[j];
    }
    return array;
}

// Метод, выводящий сообщение о строке 2D массива с минимальной суммой 
void IndexMinSumRow(int[,] array)
{
    int curSum = 0, min = 0, tempSum = 0, minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        curSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            curSum += array[i, j];
        if (i == 0) tempSum = curSum;
        if (curSum < tempSum)
        {
            min = i + 1;
            minSum = curSum;
        }
    }
    Console.WriteLine($"Номер строки {min} с минимальной суммой {minSum}.");
}

// Метод, производящий умножение двух матриц
int[,] Arrays2dMultiplication(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < resultArray.GetLength(0); i++)
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                int currentSum = 0;
                for (int k = 0; k < array2.GetLength(0); k++)
                    currentSum += array1[i, k] * array2[k, j];
                resultArray[i, j] = currentSum;
            }
        return resultArray;
    }
    else return resultArray;
}

//------------------------------------------------------------------


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int[,] arr = CreateRandom2dArray();
int[,] arrSorted = Sort2dArray(arr, false);
Show2dArray(arr, true);
Console.WriteLine();
Show2dArray(arrSorted, true);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] arr = CreateRandom2dArray();
Show2dArray(arr, true);
IndexMinSumRow(arr);
Console.WriteLine();
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int[,] arr = CreateRandom2dArray();
int[,] arr2 = CreateRandom2dArray();
int[,] resultArray = Arrays2dMultiplication(arr, arr2);
Show2dArray(arr, true);
Show2dArray(arr2, true);
Show2dArray(resultArray, true);
Console.WriteLine();
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int[,,] array = CreateRandom3dArray(true);
Console.WriteLine();
Show3dArray(array);
Show3dArrayString(AddIndexesTo3dArrayElements(array));
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] arr = new int[3, 3];
int step = 1;
for (int i = 0; i < arr.GetLength(0)/2; i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = step;
    }
}




Show2dArray(arr, true);