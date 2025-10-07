using System;

class LabExperiment
{
    static void Main()
    {
        // Выводим верхнюю границу
        Console.WriteLine("*********************************************************");

        // Ввод начальных данных
        Console.Write("Введите количество бактерий: ");
        int bacteria = int.Parse(Console.ReadLine());
        
        Console.Write("Введите количество антибиотика: ");
        int antibioticDrops = int.Parse(Console.ReadLine());

        // Начальная сила антибиотика
        int antibioticPower = 10;
        int hour = 1;

        // Обработка эксперимента
        while (bacteria > 0 && antibioticPower > 0 && antibioticDrops > 0)
        {
            // Увеличиваем количество бактерий в два раза
            bacteria *= 2;

            // Вычисляем общее количество убитых бактерий
            int killedBacteria = antibioticPower * antibioticDrops;
            
            // Уменьшаем количество бактерий
            if (killedBacteria > bacteria)
            {
                bacteria = 0;
            }
            else
            {
                bacteria -= killedBacteria;
            }

            // Выводим результат за час
            Console.WriteLine($"После {hour} часа бактерий осталось {bacteria}");

            // Уменьшаем эффективность антибиотика
            antibioticPower--;
            hour++;
        }

        // Выводим нижнюю границу
        Console.WriteLine("*********************************************************");
    }
}
