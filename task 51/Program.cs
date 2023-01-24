﻿// // Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(-10, 11);
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    } Console.WriteLine();
} 
void SumDiagonal(int[,] matrix, int m, int n)
{
    int Sum = 0;
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            if(i == j)
            {
                Sum += matrix[i,j];
            }     
        }
    } Console.WriteLine("Сумма элементов главной диагонали: " + Sum);
}
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix, m, n);
SumDiagonal(matrix, m, n);