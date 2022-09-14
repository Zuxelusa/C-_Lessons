
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

//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row1 < array.GetLength(1) && row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
        return array;
    }
    return array;
}
/*
int[,] array = CreateRandom2dArray();
Show2dArray(array);
Show2dArray(ChangeRows(array, 2, 5));
*/
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// реализация через диагональ

int[,] array = CreateRandom2dArray();

int[,] TransponArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            newArray[j,i] = array[i,j];
    return newArray;
}

//Транспонирование через главную диагональ, выполняется при условии квадратного массива
int[,] TransponArrayThroughDiagonal(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {   
        int temp;
        for (int i = 1; i < array.GetLength(0); i++)
            for (int j = 0; j < i; j++)
            {
                temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        return array;
    }
    else return array;
}

Show2dArray(array);
Console.WriteLine();

//Show2dArray(TransponArray(array));
Show2dArray(TransponArrayThroughDiagonal(array));

/*
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] array = CreateRandom2dArray();

int[,] DeleteRowColumnOfMin(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int min = array[0,0], minX = 0, minY = 0, temp;
    int[,] newArray = new int[x - 1, y - 1];
        
    //Находим минимальное значение в массиве minX и minY
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            if (array[i, j] < min)
            {
                min = array[i, j];
                minX = i;
                minY = j;
            }
    Console.WriteLine($"Минимальное значение в {minX}, {minY}");
    Console.WriteLine();

    // Проходим по элементам массива изначального, пропускаем строку и столбец минимального значения
    for (int i = 0, m = 0; i < x; i++, m++)
    {
        if (i == minX) i++;
        for (int j = 0, n = 0; j < y; j++, n++)
        {
            if (j == minY) j++;
            newArray[m, n] = array[i, j];
        }
    }
    return newArray;
}

Show2dArray(array);
Console.WriteLine();
Console.WriteLine();
Show2dArray(DeleteRowColumnOfMin(array));
*/