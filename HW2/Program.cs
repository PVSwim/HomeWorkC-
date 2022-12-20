// See https://aka.ms/new-console-template for more information

/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int MiddleNumber(int number)
{
    return (number / 10) % 10;

}

Console.Write("Input  number ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 > 999 || number1 < 100)
{
    Console.WriteLine("Number must be >100 and <999 ");
}
else
{
    int result = MiddleNumber(number1);
    Console.WriteLine($"Input number is {number1} and result is {result}");
}
*/
/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int thirdNumber(int number)
{

    return (number/100)%10;

}

Console.Write("Input  number ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 < 100)
{
    Console.WriteLine("Number must be >100");
}
else
{
    int result = thirdNumber(number1);
    Console.WriteLine($"Input number is {number1} and result is {result}");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
//проверяет, является ли этот день выходным.

bool WeekEnd(int number)
{
    return (number == 6 || number == 7);

}

Console.Write("Input  weekday number ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0 || number1 > 7)
{
    Console.WriteLine("Number must be from 1 to 7");
}
else
{
    bool result = WeekEnd(number1);
    Console.WriteLine($"Input number is {number1} and result is {result}");
}
