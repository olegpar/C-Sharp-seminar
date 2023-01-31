﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    // N = 5 -> "5, 4, 3, 2, 1"
    // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

    void PrintNumbers(int number)
    {
        if(number == 0)
        {
            return;
        }
        PrintNumbers(number + 1);
        Console.Write(-number + " ");
    }

    Console.WriteLine("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    N = -N;
    PrintNumbers(N);