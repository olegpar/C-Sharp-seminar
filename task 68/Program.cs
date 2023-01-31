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
