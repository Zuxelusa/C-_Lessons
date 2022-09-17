// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
/*
void NaturalNumOutput(int m, int n)
{    
    Console.Write (m + " ");
    if (m < n) NaturalNumOutput(m + 1, n);
    if (m > n) NaturalNumOutput(m - 1, n);
}

NaturalNumOutput(10, 1);
Console.WriteLine();
NaturalNumOutput(1, 10);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int FindSumBetween(int m, int n)
{
    if (m < n) return FindSumBetween(m + 1, n) + m;
    return m;
}

Console.Write($"{FindSumBetween(1, 5)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int AnkermanFunc(int m, int n)
{
    
    if (m > 0 && n > 0)
    {

    }
    if (m = 0)
    {

    }
    if (m > 0 && n == 0)
    {

    }
}


