/*

int FindBiggerDigit (int number)
{
int ed = number % 10;
int dec = number / 10;

int result;

if (ed > dec) result = ed;
else result = dec;

return result;
};

int RandNumber = new Random().Next (10,100);
int biggerDigit = FindBiggerDigit(RandNumber);

Console.WriteLine($"bigger digit of {RandNumber} is {biggerDigit}");

*/


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int DeleteSecondDigit(int number)
{
    int hun = number / 100;
    int ed = number % 10;
    int result = hun * 10 + ed;
    return result;
};

int num2 = new Random().Next(100, 1000);

int result = DeleteSecondDigit(num2);

Console.WriteLine($"Number is {result} from {num2}");
*/
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
/*
void Ostatok(int num1, int num2)
{
    if ((num1 % num2) > 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine($"Остаток от деления равен {num1 % num2}");
    };
};

Ostatok (2, 4);
*/
/*
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

bool isMultiple(int number, int num1, int num2)
{
    return (number % num1 == 0) && (number % num2 == 0);
};

Console.Write("Write the numer: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат вычисления: {isMultiple(x, 7, 23)}");
*/
/*
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool isSquare(int num1, int num2)
{
    return (num1 * num1 == num2) || (num2 * num2 == num1);
};

Console.Write("Write the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Write the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат вычисления: {isSquare(num1, num2)}");
*/






