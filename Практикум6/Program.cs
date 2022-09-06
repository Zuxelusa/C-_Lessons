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

int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
/*
Console.Write("Input the size of array to sum negative integers: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("From: ");
int minv = Convert.ToInt32(Console.ReadLine());
Console.Write("To: ");
int maxv = Convert.ToInt32(Console.ReadLine());

int[] newArr = CreateRandomArray(size, minv, maxv);

Console.Write($"The sum of neg integers of array: ");
PrintArray(newArr);
PrintArray(ReverseArray(newArr));
*/

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string ConvertToDouble(int N, int S)
{
    string str = String.Empty;
    int Ost;
    int tempSum = N;
    while (tempSum > 0)
    {
        Ost = tempSum % S;
        tempSum = tempSum / S;
        str = Ost + " " + str;
    }

    return str;
}
/*
Console.Write("Input the integer to convert: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the system: ");
int S = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your number is: {ConvertToDouble(N, S)}");
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//F(i) = F(i - 1) + F(i - 2)

int[] Fib(int N, int a, int b)
{
    int[] arr = new int[N];
    arr[0] = a;
    arr[1] = b;
    for (int i = 2; i < N; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}
/*
PrintArray(Fib(8, -10, -4));
*/

//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник сo сторонами такой длины.

bool isTriangle(double a, double b, double c)
{
    if (a + b > c)
    {
        if (a + c > b)
        {
            if (b + c > a) return true;
        }
    }
    return false;
}
Console.WriteLine($"Triangle is {isTriangle(10, 21, 12)}");