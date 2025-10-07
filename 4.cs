using System;

class NumberGuesser
{
    static void Main()
    {
        Console.WriteLine("Загадайте число от 0 до 63 в уме.");
        Console.WriteLine("Я задам вам 7 вопросов, на которые нужно отвечать 1 (да) или 0 (нет).");
        Console.WriteLine("Нажмите Enter, когда будете готовы...");
        Console.ReadLine();

        int number = 0;
        int[] powers = { 32, 16, 8, 4, 2, 1, 0 }; // 7 вопросов, последний вопрос фиктивный

        for (int i = 0; i < 7; i++)
        {
            if (i == 6)
            {
                Console.WriteLine("Последний вопрос (для достижения 7 вопросов): Ваше число больше 63?");
                Console.Write("Введите 0: ");
                Console.ReadLine(); // просто для соблюдения условия 7 вопросов
                break;
            }

            Console.Write($"Ваше число больше или равно {number + powers[i]}? (1/0): ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                number += powers[i];
            }
        }

        Console.WriteLine($"Я думаю, ваше число: {number}");
        Console.Write("Угадал? (1 - да, 0 - нет): ");
        int check = int.Parse(Console.ReadLine());

        if (check == 1)
        {
            Console.WriteLine("Ура! Я угадал!");
        }
        else
        {
            Console.WriteLine("Похоже, я ошибся. Попробуем ещё раз!");
        }
    }
}
