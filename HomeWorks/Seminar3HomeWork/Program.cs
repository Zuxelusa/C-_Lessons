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

double[] DotsCoord = new double[6];
int i = 0, Q = 2, N = 3, dotsCount = 0;
while (dotsCount < Q)
{
    int coordCount = 0;
    while (coordCount < N)
    {
        Console.Write($"Input {dotsCount + 1} dot coordinate {coordCount + 1}: ");
        DotsCoord[i] = Convert.ToDouble(Console.ReadLine());
        coordCount++;
        i++;
    };
    dotsCount++;
};

double Len = LengthBetweenDots(DotsCoord[0], DotsCoord[1], DotsCoord[2], DotsCoord[3], DotsCoord[4], DotsCoord[5]);
Console.WriteLine($"Length of your line with dots coordinates ({DotsCoord[0]}, {DotsCoord[1]}, {DotsCoord[2]} и {DotsCoord[3]}, {DotsCoord[4]}, {DotsCoord[5]}) is: {Math.Round(Len, 2)}.");

*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeTable(int N)
{
    int rev = 1;
    if (N < 0) rev = -1;

    int count = 0;
    while (count <= Math.Abs(N))
    {
        Console.WriteLine($"Cube of {count * rev} is {Math.Pow(count * rev, 3)}. ");
        count++;
    }
};

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

CubeTable(num);