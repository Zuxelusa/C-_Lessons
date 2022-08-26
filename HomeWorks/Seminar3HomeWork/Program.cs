// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
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
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double LengthBetweenDots(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double xCat = xB - xA;
    double yCat = yB - yA;
    double zCat = zB - zA;
    return Math.Sqrt(xCat * xCat + yCat * yCat + zCat * zCat);
}


Console.Write("Input X of Dot 1 coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Y of Dot 1 coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Z of Dot 1 coordinate: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input X of Dot 2 coordinate: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Y of Dot 2 coordinate: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Z of Dot 2 coordinate: ");
double zB = Convert.ToDouble(Console.ReadLine());

double Len = LengthBetweenDots(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Length of your line with dots coordinates ({xA}, {yA}, {zA} и {xB}, {yB}, {zB}) is: {Math.Round(Len, 2)}.");

*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.