// Seminary 1

/*
//HW Task #2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number "); int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number "); int number2 = Convert.ToInt32(Console.ReadLine());

//int max = Math.Max(number2, number1);//version 2
int max = number1;

if (number2 > max) max = number2;

Console.WriteLine("Maximum is " + max);

*/

/*
// HW Task 4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number "); int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number "); int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number  "); int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine("Maximum is " + max);

*/

/*
// HW Task 6
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number  "); int number1 = Convert.ToInt32(Console.ReadLine());

if (number1%2 == 0) 
{
    Console.WriteLine(number1  + " is even number");    
}
else
{
    Console.WriteLine(number1  + " is odd number");
}
*/

/*
// HW Task 8
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number  ");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = 0;
if ((number1 == 1) | ( number1 < 0))
{
    Console.WriteLine("No even numbers");
}
else
{
    string resulteven = " Even numbers are ";

    while (number1 >= count)
    {
        if (count % 2 == 0) resulteven = resulteven + " " + count;
        count++;
    }
    Console.WriteLine(resulteven);
}
*/

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
