//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] LinearEQuation(double[] line1, double[] line2)
{
    double[] result = new double[2];
    result[0] = (line2[1] - line1[1]) / (line1[0] - line2[0]);
    result[1] = line1[0]*result[0]+line1[1];
    return result;
}


double[] InputLine()
{
    Console.WriteLine("Please, input line as y=a*x+b");
    double[] result = new double[2];
    Console.WriteLine("Please, input a");
    result[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please, input b");
    result[1] = Convert.ToDouble(Console.ReadLine());
    return result;
}

double[] line1 = new double[2]; line1 = InputLine();
double[] line2 = new double[2]; line2 = InputLine();

if (line1[0] == line2[0] && line1[1] == line2[1]) Console.WriteLine("infinite set, the lines are identical");
else if (line1[0] == line2[0] && line1[1] != line2[1]) Console.WriteLine("No solution, lines are parallel");
else
{
    double[] result = new double[2];
    result = LinearEQuation(line1, line2);
    Console.WriteLine($"Y={line1[0]}*X+{line1[1]} and Y={line2[0]}*X+{line2[1]}");
    Console.WriteLine($"Solution is X = {result[0]} and Y ={result[1]}");
}



