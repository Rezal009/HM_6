// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значения для первой прямой (y = k1 * x + b1):");
        double k1 = ReadDouble("k1");
        double b1 = ReadDouble("b1");

        Console.WriteLine("Введите значения для второй прямой (y = k2 * x + b2):");
        double k2 = ReadDouble("k2");
        double b2 = ReadDouble("b2");

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
    }

    static double ReadDouble(string name)
    {
        Console.Write($"Введите значение {name}: ");
        return Convert.ToDouble(Console.ReadLine());
    }
}
