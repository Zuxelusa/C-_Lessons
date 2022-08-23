// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int ShowSecondDigit(int num)
{
    return (num / 10) - (num / 100 * 10);
};

again:

Console.Write("Input the 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number >= 100) & (number < 1000))
{
    Console.WriteLine($"The second digit of {number} is {ShowSecondDigit(number)}");
}
else
{
    Console.WriteLine("You inputed incorrect number. ");
    goto again;
};
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



int NumberLength(int x)
{
    int count = 1,  rank = 10, temp = 0;
    while (rank <= x)
    {
        temp = x / rank;
        rank *= 10;
        count++;
    };
    return count;
};

Console.Write(NumberLength(15687951));
/*
int ShowThirdDigit(int num)
{
    int x = (Math.Abs(num) / 100) % 10;
    if (Math.Abs(num) < 100) x = -1;
    return x;
};

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = ShowThirdDigit(number);
if (num != -1)
{
    Console.WriteLine($"The third digit of {number} is {num}.");
}
else
{
    Console.WriteLine($"There is no third digit in number {number}.");
};
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool isWeekend(int x)
{
    if ((x == 6) || (x == 7))
    {
        return true;
    }
    else
    {
        return false;
    };
};

string DayName(int y)
{
    if (y == 1) return "Monday";
    if (y == 2) return "Tuesday";
    if (y == 3) return "Wednesday";
    if (y == 4) return "Thursday";
    if (y == 5) return "Friday";
    if (y == 6) return "Saturday";
    if (y == 7) return "Sunday";
    return "";
};

again:

Console.Write("Input the number of day from 1 to 7: ");
int weekDay = Convert.ToInt32(Console.ReadLine());

if (weekDay > 0 & weekDay < 8)
{
    if (isWeekend(weekDay))
    {
        Console.WriteLine($"The {DayName(weekDay)} is holiday!");
    }
    else
    {
        Console.WriteLine($"The {DayName(weekDay)} is workday.");
    };
}
else
{
    Console.WriteLine($"Incorrect day. Try again.");
    goto again;
};
*/

