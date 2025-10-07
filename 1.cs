using System;

class MaclaurinSeries
{
    // Функция для вычисления факториала
    private static long Factorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }

    // Вычисление n-го члена ряда Маклорена для sin(x)
    private static double CalculateTerm(int n, double x)
    {
        int sign = (n % 2 == 0) ? 1 : -1;
        int power = 2 * n + 1;
        return sign * Math.Pow(x, power) / Factorial(power);
    }

    // Вычисление суммы ряда с заданной точностью
    private static double CalculateSeries(double x, double epsilon)
    {
        double sum = 0;
        double currentTerm = x;
        int n = 0;
        
        while (Math.Abs(currentTerm) > epsilon)
        {
            sum += currentTerm;
            n++;
            currentTerm = CalculateTerm(n, x);
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Программа вычисления ряда Маклорена для sin(x)");
        Console.WriteLine("---------------------------------------------");

        // Режим 1: вычисление с заданной точностью
        Console.WriteLine("\nРежим 1: вычисление с заданной точностью");
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());
        
        Console.Write("Введите точность e (e < 0.01): ");
        double epsilon = double.Parse(Console.ReadLine());
        
        if (epsilon >= 0.01)
        {
            Console.WriteLine("Ошибка: точность должна быть меньше 0.01");
            return;
        }

        double result = CalculateSeries(x, epsilon);
        Console.WriteLine($"Результат: sin({x}) ≈ {result}");

        // Режим 2: вычисление n-го члена ряда
        Console.WriteLine("\nРежим 2: вычисление n-го члена ряда");
        Console.Write("Введите x: ");
        x = double.Parse(Console.ReadLine());
        
        Console.Write("Введите номер члена n: ");
        int n = int.Parse(Console.ReadLine());
        
        double term = CalculateTerm(n, x);
        Console.WriteLine($"Значение {n}-го члена ряда: {term}");
    }
}
