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
