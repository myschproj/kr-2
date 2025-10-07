using System;

class FractionReducer
{
    // Метод для нахождения НОД (наибольшего общего делителя)
    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        // Выводим верхнюю границу
        Console.WriteLine("*********************************************************");
        
        // Ввод числителя
        Console.Write("Введите числитель: ");
        int numerator = int.Parse(Console.ReadLine());
        
        // Ввод знаменателя
        Console.Write("Введите знаменатель: ");
        int denominator = int.Parse(Console.ReadLine());
        
        // Проверка на ноль в знаменателе
        if (denominator == 0)
        {
            Console.WriteLine("Ошибка: знаменатель не может быть равен нулю!");
            return;
        }
        
        // Находим НОД числителя и знаменателя
        int divisor = GCD(Math.Abs(numerator), Math.Abs(denominator));
        
        // Сокращаем дробь
        int reducedNumerator = numerator / divisor;
        int reducedDenominator = denominator / divisor;
        
        // Выводим результат
        Console.WriteLine($"Результат: {reducedNumerator} / {reducedDenominator}");
        
        // Выводим нижнюю границу
        Console.WriteLine("*********************************************************");
    }
}
