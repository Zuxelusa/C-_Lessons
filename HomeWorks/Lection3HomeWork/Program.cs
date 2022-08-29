//Написать программу которая выстроит массив по убыванию

int[] array = { 5, 1, 7, 4, 9, 10, 18, 56, 37, 32, 1, 2, 3, 8 };


void MassiveWrite(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void SelectionSort(int[] arr)
{
    string str = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < arr.Length-1; j++)
        {
            if (arr[j] > arr[maxPosition]) maxPosition = j;
        }
        int temporary = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temporary;
    }
}

MassiveWrite(array);
Console.WriteLine("");
SelectionSort(array);
MassiveWrite(array);