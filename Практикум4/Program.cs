
/*
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int FindSum(int a)
{
    int sum = 0;

    for (int i = 0; i <= a; i++)
        sum += i;
    
    return sum;
}

Console.Write("Input the integer: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}. ");
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int QuaNumbers(int N)
{
    int current = 0;
    for (int i = 0; N > 0; i++)
    {
        N /= 10;
        current++;
    }
    return current;
}


Console.WriteLine(QuaNumbers(104654000));
Console.WriteLine("");

string num = Console.ReadLine();

Console.WriteLine("");
Console.Write(num.Length);
*/
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Proizv(int n)
{
    int num = 1;
    for (int i = 1; i <= n; i++)
        num *= i;
    
    return num;
}
Console.Write(Proizv(3));
*/
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] Random(int N)
{
    //int[] arr = new int[N];
    int[] arr;

    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

PrintArray(Random(15));