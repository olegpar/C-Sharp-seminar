﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных чисел

int [] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-9, 10);
        }
        return array;
}

int[] array = new int[5];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(" ", array));

int sumPositive = 0;
int sumNegative = 0;

for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sumPositive += array[i];
        }
        else
            sumNegative += array[i];
    }
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}, а сумма положительных чисел = {sumPositive}");