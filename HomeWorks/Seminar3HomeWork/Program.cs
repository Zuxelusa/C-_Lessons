// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int NumberLength(int x)
{
    int count = 1, rank = 10;
    while (rank <= Math.Abs(x))
    {
        rank *= 10;
        count++;
    };
    return count;
};

bool isPalindrom(int N)
{
    int count = 0;

    while (count < NumberLength(N) / 2)
    {
        int First = N / Convert.ToInt32(Math.Floor(Math.Pow(10, NumberLength(N) - count - 1))) % 10;
        // обнаружил, что при конвертации из double в Int он округляет по математическому правилу, а нужно отсекать дробную часть. Поэтому добавил Floor
        int Last = Convert.ToInt32(Math.Floor((N / Math.Pow(10, count)) % 10));
        if (First != Last)
        {
            return false;
        }
        count++;
    }
    return true;
};

string iP;

Console.Write("Input any Int32 number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (isPalindrom(num))
{
    iP = "";
}
else
{
    iP = "not ";
};

Console.WriteLine($"Number {num} is {iP}palindrome.");


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.