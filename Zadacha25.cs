/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Write("Введите число А: ");
double A = double.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
double B = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Число А в степени В = {Exp(A)}");

double Exp(double a)
{
    double i = 0;
    double res = A;
    if (B>=0)
    {
        while (i<=B)
        {
            res = Math.Pow(A, i);
            i++;
        }
        return res;
    }
    else
    {
        while (i<=Math.Abs(B))
        {
            res = 1/Math.Pow(A, i);
            i++;
        }
        return res;
    }
}
//Второй вариант решения: более простой, но без использования метода:

/* Console.Write("Введите число А: ");
double A = double.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
double B = double.Parse(Console.ReadLine()!);

double res = Math.Pow(A, B);
Console.WriteLine("Число А в степени В = " + res); */