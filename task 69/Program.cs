﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int exponentiation(int n, int m)
{
    int exp = 1;
    if(m == 0) return exp;
    else return exp = n*exponentiation(n, m-1);
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

int exp = exponentiation(n, m);

Console.WriteLine(exp);