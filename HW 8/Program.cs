Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 54:
    // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2

    void FillArrayWithRandom(int[,] matrix)
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    matrix[i, j] = new Random().Next(0, 10);
    }
    }
    }
    void PrintArrayWithRandom(int[,] matrix)
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
    }
    Console.WriteLine();
    }

    Console.WriteLine("Введите число m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n:");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[m, n];
    FillArrayWithRandom(matrix);
    PrintArrayWithRandom(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for(int j = 0; j < matrix.GetLength(1); j++)
        { 
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i,j] <= matrix[i,k]) continue;
                int temp = matrix[i,j];
                matrix[i,j] = matrix[i,k];
                matrix[i,k] = temp;
            }
        }
    }
    Console.WriteLine();
    PrintArrayWithRandom(matrix);
    break;

    case 56:
    // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

    void FillArrayWithRandom2(int[,] matrix2, int m2, int n2)
        {
            for(int i = 0; i < m2; i++)
            {
                for(int j = 0; j < n2; j++)
                {
                    matrix2[i,j] = new Random().Next(0, 10);
                    Console.Write(matrix2[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
        void SumMin(int[,] matrix2, int m2, int n2)
    {
        int index = 0, minsum = 0;
        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                sum += matrix2[i, j];
            }
            Console.WriteLine($"Сумма {i + 1} строки = {sum}");
            if (i == 0)
            {
                minsum = sum;
            }
            else if (sum < minsum)
            {
                minsum = sum;
                index = i;
            }
        }
        Console.WriteLine($"Строка с наименьшей суммой элементов: {index + 1} строка.");
    }
            Console.WriteLine("Введите число m2:");
            int m2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Введите число n2 не равное m2:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if(m2 == n2)
            {
                Console.WriteLine("Вы ввели два одинаковых числа. Введите два разных числа");
            }
            int [,] matrix2 = new int[m2,n2];
            FillArrayWithRandom2(matrix2, m2, n2);
            SumMin(matrix2, m2, n2);
    break;

    case 60:
    // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    // Массив размером 2 x 2 x 2
    // 66(0,0,0) 25(0,1,0)
    // 34(1,0,0) 41(1,1,0)
    // 27(0,0,1) 90(0,1,1)
    // 26(1,0,1) 55(1,1,1)

    Console.WriteLine("Введите число x:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число y:");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число z:");
    int z = Convert.ToInt32(Console.ReadLine());

    int[,,] array3D = new int[x, y, z];
    CreateArray(array3D);
    WriteArray(array3D);

    void WriteArray(int[,,] array3D)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                for (int k = 0; k < array3D.GetLength(2); k++)
                {
                    Console.Write($"{array3D[i, j, k]}({i},{j},{k})\t");
                }
                Console.WriteLine();
            }
        }
    }
    void CreateArray(int[,,] array3D)
    {
        int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
        int number;
        for (int i = 0; i < temp.GetLength(0); i++)
        {
            temp[i] = new Random().Next(10, 100);
            number = temp[i];
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (temp[i] == temp[j])
                    {
                        temp[i] = new Random().Next(10, 100);
                        j = 0;
                        number = temp[i];
                    }
                    number = temp[i];
                }
            }
        }
        int count = 0;
        for (int x = 0; x < array3D.GetLength(0); x++)
        {
            for (int y = 0; y < array3D.GetLength(1); y++)
            {
                for (int z = 0; z < array3D.GetLength(2); z++)
                {
                    array3D[x, y, z] = temp[count];
                    count++;
                }
            }
        }
    }
    break;

    default:
        Console.WriteLine("Такого задания не существует");
    break;
    }
