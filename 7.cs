using System;

class MarsColony
{
    static void Main()
    {
        // Выводим верхнюю границу
        Console.WriteLine("*********************************************************");

        // Ввод параметров
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        
        Console.Write("Введите w: ");
        int w = int.Parse(Console.ReadLine());
        
        Console.Write("Введите h: ");
        int h = int.Parse(Console.ReadLine());

        // Начальная максимальная толщина защиты
        int maxD = 0;

        // Поиск максимальной возможной толщины защиты
        for (int d = 0; ; d++)
        {
            // Размеры модуля с защитой
            int moduleWidth = a + 2 * d;
            int moduleHeight = b + 2 * d;

            // Максимальное количество модулей по ширине и высоте
            int maxModulesWidth = w / moduleWidth;
            int maxModulesHeight = h / moduleHeight;

            // Общее количество модулей
            int totalModules = maxModulesWidth * maxModulesHeight;

            // Если модулей меньше требуемого количества, то прерываем цикл
            if (totalModules < n)
            {
                break;
            }

            // Обновляем максимальную толщину защиты
            maxD = d;
        }

        // Выводим результат
        Console.WriteLine($"Ответ d = {maxD}");

        // Выводим нижнюю границу
        Console.WriteLine("*********************************************************");
    }
}
