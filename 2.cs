using System;

class Program
{
    static void Main()
    {
        // Выводим верхнюю границу
        Console.WriteLine("*********************************************************");
        
        // Основной цикл программы
        while (true)
        {
            // Запрос ввода номера билета
            Console.Write("Введите номер билета: ");
            
            // Получаем ввод от пользователя
            string input = Console.ReadLine();
            
            // Проверяем, что введенное значение является числом
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Ошибка: введите корректное шестизначное число!");
                continue;
            }
            
            // Проверяем, что число шестизначное
            if (number < 100000 || number > 999999)
            {
                Console.WriteLine("Ошибка: число должно быть шестизначным!");
                continue;
            }
            
            // Извлекаем цифры из числа
            int firstDigit = number / 100000;        // первая цифра
            int secondDigit = (number / 10000) % 10;  // вторая цифра
            int thirdDigit = (number / 1000) % 10;    // третья цифра
            
            int fourthDigit = (number / 100) % 10;    // четвертая цифра
            int fifthDigit = (number / 10) % 10;      // пятая цифра
            int sixthDigit = number % 10;             // шестая цифра
            
            // Вычисляем суммы
            int sumFirstHalf = firstDigit + secondDigit + thirdDigit;
            int sumSecondHalf = fourthDigit + fifthDigit + sixthDigit;
            
            // Выводим результат
            Console.WriteLine(sumFirstHalf == sumSecondHalf);
        }
        
        // Выводим нижнюю границу (этот код не выполнится из-за бесконечного цикла)
        Console.WriteLine("*********************************************************");
    }
}
