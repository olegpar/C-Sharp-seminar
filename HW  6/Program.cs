Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 41:
    // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    // 0, 7, 8, -2, -2 -> 2
    // 1, -7, 567, 89, 223-> 3

    Console.WriteLine("Введите число элементов массива");
    int M = Convert.ToInt16(Console.ReadLine());

    int [] array = new int[M];
    int i = 0;
    while (i < M)
        {
            Console.WriteLine("Введите элемент массива");
            array[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }

    Console.Write("Ваш массив: ");
    for (i = 0; i < M; i++)
        {
            Console.Write(array[i] + " ");
        }

    int count=0;
    for (i = 0; i < M; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Количество положительных чисел: " + count);
    break;

    case 43:
    // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
    // y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

    Console.WriteLine("Введите начальную точку первой прямой: ");
    double b1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите конечную точку первой прямой: ");
    double k1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите начальную точку второй прямой: ");
    double b2 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите конечную точку второй прямой: ");
    double k2 = Convert.ToInt16(Console.ReadLine());

    if(b1 == b2 || k1 == k2)
    {
        Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
    }
    break;

    default:
        Console.WriteLine("Такого задания не существует");
    break;
    }