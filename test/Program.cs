﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
       Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string S = number.ToString();
        if(S[0] == S[4] && S[1] == S[3])
        {
            Console.WriteLine("Это число является палиндромом");
        }
        else
        {
            Console.WriteLine("Это число НЕ является палиндромом");
        }
