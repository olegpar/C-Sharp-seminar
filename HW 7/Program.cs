Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 47:
    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9

    void FillArrayWithRandom(double[,] matrix, double m, double n)
    {
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                matrix[i,j] = Math.Round(new Random().Next(-10, 11) + new Random().NextDouble(), 1);
                Console.Write(matrix[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine("Введите число m:");
    int m = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите число n:");
    int n = Convert.ToInt32(Console.ReadLine());
    double [,] matrix = new double[m,n];
    FillArrayWithRandom(matrix, m, n);
    break;

    case 50:
    // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 1, 7(ввод индексов) -> такого числа в массиве нет
    // 1, 1 -> 9

    void FillArrayWithRandom1(int[,] matrix1, int m1, int n1)
    {
        for(int i = 0; i < m1; i++)
        {
            for(int j = 0; j < n1; j++)
            {
                matrix1[i,j] = new Random().Next(0, 10);
                Console.Write(matrix1[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
    void CheckTheElement(int[,] matrix1, int m1, int n1, int index1, int index2)
    {
        int count = 0;
        for(int i = 0; i < m1; i++)
        {
            for(int j = 0; j < n1; j++)
            {
                if(i == index1 && j == index2)
                {
                    Console.Write($"Элемент под индексом ({index1}, {index2}): {matrix1[i,j]}");
                    count++;
                }
            }
        }
        if(count == 0)
        Console.Write("Такого индекса в массиве нет");
    }

    Console.WriteLine("Введите число m1:");
    int m1 = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите число n1:");
    int n1 = Convert.ToInt32(Console.ReadLine());
    int [,] matrix1 = new int[m1,n1];
    FillArrayWithRandom1(matrix1, m1, n1);
    Console.WriteLine("Введите первый индекс массива:");
    int index1 = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите второй индекс массива:");
    int index2 = Convert.ToInt32(Console.ReadLine());
    CheckTheElement(matrix1, m1, n1, index1, index2);
    break;

    case 52:
    // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3 
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

    void FillArrayWithRandom2(int[,] matrix2, int m2, int n2)
    {
        for(int i = 0; i < m2; i++)
        {
            for(int j = 0; j < n2; j++)
            {
                matrix2[i,j] = new Random().Next(0, 10);
                Console.Write(matrix2[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
    void ArithmeticMean(int[,] matrix2, int m2, int n2)
    {
    double Sum = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
        for(int j = 0; j < n2; j++)
        {
            for(int i = 0; i < m2; i++)
            {
                Sum += matrix2[i,j];
            }
            Console.Write(Math.Round(Sum / n2, 1) + "; ");
            Sum = 0;
        }
    } 
        Console.WriteLine("Введите число m2:");
        int m2 = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Введите число n2:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int [,] matrix2 = new int[m2,n2];
        FillArrayWithRandom2(matrix2, m2, n2);
        ArithmeticMean(matrix2, m2, n2);
    break;

    default:
        Console.WriteLine("Такого задания не существует");
    break;
    }
