

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212->нет 12821->да 23432->да
// два варианта
/*
bool CheckPalindrome(int number) //зеркалируем число и сравниваем с исходным, если равно то True 
{
    
    int palindrome = 0;
    int remainNumber= number;

    while (remainNumber > 0)
    {
        palindrome = palindrome * 10 + remainNumber % 10;
        remainNumber=remainNumber/10;
    }
    
    return (number == palindrome);
}
*/

/*
bool CheckPalindrome(int number)//последательно сравниваем первую и последнюю цифру, если не равны, то false. 
// новое числе =откидываем старшую и младшую цифру
{
    int digitCount = (int)Math.Log10(number) + 1;//разряд числа
    
    while (digitCount>=2)
    //пока разряд больше или равно 2, если в исходном числе нечетное число разрядов, последнее не проверям, она равно само себе
    {
        int dig_10x =(int)Math.Pow(10,digitCount-1);
        int firstNumber=number/dig_10x;//первая цифра
        int lastNumber=number % 10;// последняя цифра
        if(firstNumber==lastNumber)
        {
            number=(number-firstNumber*dig_10x)/10;  //новое число без первой и последней цифр          
            digitCount = digitCount -2;//число уменьшилось на два разряда
        }
        else
        {
            return false;
        }
    }
    return true;
}
*/

/*
Console.WriteLine("Please input number >0");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} is palindrome {CheckPalindrome(number)}");

*/

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84 A (7,-5, 0); B (1,-1,9) -> 11.53
/*

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Round(result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
    return result;
}

Console.WriteLine("Please input 3D cooridate of 1st point");
Console.Write(" X ");
double xx1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Y ");
double yy1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Z ");
double zz1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please input 3D cooridate of 2nd point");
Console.Write(" X ");
double xx2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Y ");
double yy2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Z ");
double zz2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance is {GetDistance(xx1, yy1, zz1, xx2, yy2, zz2)}");

*/

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27 5 -> 1, 8, 27, 64, 125
/*
void GetСubic(int number)
{
    int index = 1;
    while (index <= number)
    {
        Console.Write($"{Math.Pow(index, 3)}, ");
        index++;
    }
}

Console.WriteLine("Input number >0");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) GetСubic(number);
else  Console.WriteLine("Error input");
*/
