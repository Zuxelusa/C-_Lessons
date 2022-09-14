

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

int[,] Arrays2dMultiplication(int[,] array1, int[,] array2)
{
    int rowsArray1 = array1.GetLength(0);
    int columnsArray1 = array1.GetLength(1);
    int rowsArray2 = array2.GetLength(0);
    int columnsArray2 = array2.GetLength(1);

    if (columnsArray1 == rowsArray2)
    {
        int[,] resultArray = new int[columnsArray2, rowsArray1];
        Show2dArray(array1, true);
        Show2dArray(array2, true);

        //проходим по строкам результирующей матрицы
        for (int i = 0; i < rowsArray1; i++)
            //проходим по столбцам результирующей матрицы
            for (int j = 0; j < columnsArray2; j++)
            {
                //накапливаем новую сумму на каждом элементе нового массива, количество слагаемых ровно количеству столбцов
                int currentSum = 0;
                for (int k = 0; k < columnsArray1; k++)
                {
                    // сумма накапливается от произведений элементов 1 массива, шагая по столбцам (вправо), и элементов 2 массива, шагая по рядам (вниз)
                    currentSum += array1[i, k] * array2[k, j];
                    Console.WriteLine($"Строки: {i} Столбцы: {j} Слагаемых: {k} Сумма: {currentSum}");
                }
                resultArray[i, j] = currentSum;
            }
        return resultArray;
    }
    else return null;
}

int[,] arr = CreateRandom2dArray();
int[,] arr2 = CreateRandom2dArray();
int[,] resultArray = Arrays2dMultiplication(arr, arr2);
Show2dArray(arr, true);
Show2dArray(arr2, true);
Show2dArray(resultArray, true);
Console.WriteLine();

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
