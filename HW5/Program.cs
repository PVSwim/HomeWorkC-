
/*
int[] CreateRandArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
*/

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
/*
int CountEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum++;
    }
    return sum;
}



Console.WriteLine("Input length of array");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandArray(n, 100, 1000);
ShowArray(array);
Console.WriteLine($"Even count {CountEven(array)}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SumOddIndex(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        result=result+array[i];
    }
    return result;
        
}

Console.WriteLine("Input length of array");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandArray(n, -100, 1000);
ShowArray(array);
Console.WriteLine($"Sum of odd {SumOddIndex(array)}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandDoubleArray(int length, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble()*max;
    }
    return array;
}

double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i]) max = array[i];
            if (min > array[i]) min = array[i];
        }
        return max - min;
    }
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
    Console.WriteLine("Input length of array");
    int n = Convert.ToInt32(Console.ReadLine());
    double[] array = CreateRandDoubleArray(n, 100);
    ShowDoubleArray(array);
    Console.WriteLine($"Difference between min max {DiffMaxMin(array)}");