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

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. 
// Выведите полученный массив на экран.
/*
int[,] CreateArrayAij(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = i * j;
    return array;
}
Show2dArray(CreateArrayMNAij(5, 7));
*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] array = CreateRandom2dArray();

int[,] SqrForEven(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
        for (int j = 0; j < array.GetLength(1); j += 2)
            array[i, j] = array[i, j] * array[i, j];
    return array;
}
Show2dArray(array);
Console.WriteLine();
Show2dArray(SqrForEven(array));
*/

//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int[,] array = CreateRandom2dArray();
Show2dArray(array);

int SumForMainDiagonal(int[,] array)
{   
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];
    return sum;
}
Show2dArray(array);
Console.WriteLine();
Console.Write($"Main diagonal elements sum is {SumForMainDiagonal(array)}.");
*/

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = CreateRandom2dArray();

void FindRowSumOfMaxMin(int[,] array)
{
    int rowN = 0;
    int mSum= 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumTemp = 0; 
        
        for (int j = 0; j < array.GetLength(1); j++)
            sumTemp += array[i,j];
        if (i == 0) 
        {
            rowN = i;
            mSum = sumTemp;
        }
        if (sumTemp < mSum) 
        {
            rowN = i;
            mSum = sumTemp;
        }
    }
    Console.WriteLine($"Minimal sum is {mSum} at the {rowN + 1} row.");
}

Show2dArray(array);
Console.WriteLine();
FindRowSumOfMaxMin(array);