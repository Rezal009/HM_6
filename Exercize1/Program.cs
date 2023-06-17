// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество чисел: ");
        int count = Convert.ToInt32(Console.ReadLine());

        int positiveCount = 0;

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                positiveCount++;
            }
        }

        Console.WriteLine($"Количество чисел больше 0: {positiveCount}");
    }
}