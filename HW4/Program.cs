/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Row(int a, int b)
{
int result=1;
for (int i = 1; i <= b; i++)
{
    result=result*a;
}
return result;
}

Console.WriteLine("Input number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Row(a, b) );
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int getSum(int number)
{
    int length = (int)Math.Log10(number) + 1;
    int res = 0;
    for (int i = 1; i <= length; i++)
    {
        res = res + number % 10;
        number = number / 10;

    }
    return res;
}

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(getSum(num));
*/
//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int [] getArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
       Console.WriteLine($"Input number to {i} ");
       array[i]= Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray (int[] array)
{
    int length=array.Length;
    Console.Write("[");
    string comma=", ";
    for (int i = 0; i < length; i++)
    {
        if (i==length-1) comma="]";
        Console.Write(array[i]+comma);
    }
        
Console.WriteLine();
}

Console.WriteLine("Input size");
int m = Convert.ToInt32(Console.ReadLine());
int[] array =getArray(m);
PrintArray(array);
