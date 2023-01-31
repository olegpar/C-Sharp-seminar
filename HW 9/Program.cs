Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 64:
    // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
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
    int N1 = Convert.ToInt32(Console.ReadLine());
    N1 = -N1;
    PrintNumbers(N1);
    break;

    case 66:
    // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    // M = 1; N = 15 -> 120
    // M = 4; N = 8. -> 30

    int SumBetweenMN(int a, int b)
    {
        int sum = 0;
        for(int i = a; i <= b; i++)
        // if (a == b) return 0;
        // if (a > b)
        {
            sum += i;
        }
        return sum;
    }
    Console.WriteLine("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SumBetweenMN(M,N));
    break;

    case 68:
    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29
    int A(int m, int n)
    {int sum = 0;
        if(m == 0)
        {
            sum = n + 1;
        }
        else if(n == 0)
        {
            sum = A(m-1,1);
        }
        else if(m > 0 && n > 0)
        {
            sum = A(m-1, A(m,n-1));
        }
        return sum; 
    }
    Console.WriteLine("Введите число m:");
    int m = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите число n:");
    int n = Convert.ToInt32(Console.ReadLine());
    A(m,n);
    Console.WriteLine($"Функция Аккермана равна: {A(m,n)}");
    break;

    default:
        Console.WriteLine("Такого задания не существует");
    break;
    }
