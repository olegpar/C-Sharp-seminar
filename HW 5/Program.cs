Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 34:
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

    int [] FillArrayWithRandom(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100, 999);
            }
            return array;
    }
    int[] array = new int [5];
    FillArrayWithRandom(array);
    Console.Write("Ваш случайный массив: ");
    Console.WriteLine(string.Join(" ", array));
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array [i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine("В массиве количество четных чисел: " + count);
    break;

    case 36:
    // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    // Найдите сумму элементов, стоящих на нечётных позициях.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0

    int[] array1 = new int [5];
    FillArrayWithRandom(array1);
    Console.Write("Ваш случайный массив: ");
    Console.WriteLine(string.Join(" ", array1));
    int sum = 0;
    for(int i = 0; i < array1.Length; i++)
    {
        if(array1 [i] % 2 == 1)
        {
            sum += array1 [i];
        }
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);
    break;

    case 38:
    // Задача 38: Задайте массив вещественных чисел. 
    // Найдите разницу между максимальным и минимальным элементов массива.
    // [3.7; 7.2; 2.1; 7.8] -> 5.7

    double [] FillArrayWithRandom1(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
            {
                array[i] =  Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2);
            }
            return array;
    }
    Console.Write("Введите размер массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    double [] array2 = new double [length];
    FillArrayWithRandom1(array2);
    Console.Write("Ваш случайный массив: ");
    Console.WriteLine(string.Join(" ", array2));
    double max = array2[0];
    for(int i = 0; i < array2.Length; i++)
    {
        if(array2 [i] > max)
        {
            max = array2 [i];
        }
    }
    double min = array2[0];
    for(int i = 0; i < array2.Length; i++)
    {
        if(array2 [i] < min)
        {
            min = array2 [i];
        }
    }
    Console.WriteLine("Максимальное число: " + max);
    Console.WriteLine("Минимальное число: " + min);
    Console.WriteLine("Разница между максимальным и минимальным числом = " + (max - min));
    break;

        default:
            Console.WriteLine("Такого задания не существует");
        break;
    }