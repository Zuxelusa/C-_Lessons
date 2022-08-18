/*
int number = 5;

Console.WriteLine("My number is " + number + " and it's good!");

Console.WriteLine($"My number is {number} and it's good!");

Task 1. Do 

//Task 1.

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int kvadrat = number * number;
Console.WriteLine("Quad of " + number + " is " + kvadrat);
*/
/*
//Task 2. программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.


Console.Write("Input First integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine($"{num1} является квадратом {num2}");
}
else
{
    Console.WriteLine($"{num1} не является квадратом {num2}");
}
*/

/*
//Task 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while (current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

//Task 3. программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Input 3-digital integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int lastSymbol = num % 10;

Console.Write("The last digit is " + lastSymbol);
