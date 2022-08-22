Console.Clear();
/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("                     The program shows min and max numbers.");

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"The maximum is {num1}, the minimum is {num2}");
}
else
{
    Console.WriteLine($"The maximum is {num2}, the minimum is {num1}");
}
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("                     The program shows the maximum from inputed digits");

Console.Write("How many digits do you want to input? ");
int count = Convert.ToInt32(Console.ReadLine());

if (count > 0)
{
    int index = 0;
    int[] array = new int[count];

    while (index < count)
    {
        Console.Write($"Input {index + 1} number: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }

    int MaxValue = array.Max();
    Console.Write("The maximum of inputed digits is " + MaxValue + ".");
}
else
{
    Console.Write("You have to input positive number!");
}



/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("                     The program checks the inputed number is ODD or EVEN");

Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());

int ostatok = num / 2;

if (ostatok == 0)
{
    Console.WriteLine($"The number {num} is EVEN!");
}
else
{
    Console.WriteLine($"The number {num} is ODD!");
}

*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("                     The program shows all even digits from 1 to inputed digit.");

Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1)
{
    int index = 1;

    while (index <= num)
    {
        if (index % 2 == 0)
        {
            Console.Write(index + " ");
        }
        index++;
    }
}
else
{
    Console.Write("You have to input positive number, more then 1!");
}
*/