using System;

class CoffeeMachine
{
    // Константы для напитков
    private const int AMERICANO_WATER = 300;
    private const int LATTE_WATER = 30;
    private const int LATTE_MILK = 270;
    private const int AMERICANO_PRICE = 150;
    private const int LATTE_PRICE = 170;

    static void Main()
    {
        // Выводим верхнюю границу
        Console.WriteLine("*********************************************************");

        // Инициализация ресурсов
        Console.Write("Введите количество воды в мл: ");
        int totalWater = int.Parse(Console.ReadLine());
        
        Console.Write("Введите количество молока в мл: ");
        int totalMilk = int.Parse(Console.ReadLine());

        // Счетчики и заработок
        int amerCount = 0;
        int latteCount = 0;
        int earnings = 0;

        // Обслуживание посетителей
        while (true)
        {
            Console.Write("Выберите напиток (1 — американо, 2 — латте): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Американо
                    if (totalWater >= AMERICANO_WATER)
                    {
                        Console.WriteLine("Ваш напиток готов.");
                        totalWater -= AMERICANO_WATER;
                        amerCount++;
                        earnings += AMERICANO_PRICE;
                    }
                    else
                    {
                        Console.WriteLine("Не хватает воды");
                    }
                    break;

                case 2: // Латте
                    if (totalWater >= LATTE_WATER && totalMilk >= LATTE_MILK)
                    {
                        Console.WriteLine("Ваш напиток готов.");
                        totalWater -= LATTE_WATER;
                        totalMilk -= LATTE_MILK;
                        latteCount++;
                        earnings += LATTE_PRICE;
                    }
                    else if (totalWater < LATTE_WATER)
                    {
                        Console.WriteLine("Не хватает воды");
                    }
                    else
                    {
                        Console.WriteLine("Не хватает молока");
                    }
                    break;

                default:
                    Console.WriteLine("Неверный выбор напитка");
                    continue;
            }

            // Проверка на окончание ресурсов
            if (totalWater < AMERICANO_WATER && totalWater < LATTE_WATER || totalMilk < LATTE_MILK)
            {
                break;
            }
        }

        // Вывод отчета
        Console.WriteLine("\n*Отчёт*");
        Console.WriteLine("Ингредиентов осталось:");
        Console.WriteLine($"Вода: {totalWater} мл");
        Console.WriteLine($"Молоко: {totalMilk} мл");
        Console.WriteLine($"Кружек американо приготовлено: {amerCount}");
        Console.WriteLine($"Кружек латте приготовлено: {latteCount}");
        Console.WriteLine($"Итого: {earnings} рублей.");

        // Выводим нижнюю границу
        Console.WriteLine("*********************************************************");
    }
}
