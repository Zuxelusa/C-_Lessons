// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNums(n - 1);
    Console.Write(n + " ");
}

ShowNums(5);

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumOfDigits(int n)
{
    if (n > 0) return SumOfDigits(n / 10) + n % 10;
    else return 0;
}

Console.WriteLine(SumOfDigits(123));
*/

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void NumbersOutput(int M, int N)
{
    Console.Write(M + " ");
    if (M < N) NumbersOutput(M + 1, N);
}

NumbersOutput(3, 9);
*/
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

double PowerUp(double x, int pow)
{
    if (pow > 0) return x * PowerUp(x, pow - 1);
    if (pow < 0) return 1 / x * PowerUp(x, pow + 1);
    return 1;
}
Console.WriteLine(PowerUp(8, 3));