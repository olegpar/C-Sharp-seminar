Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 2:
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число отличное от первого: ");
        int b = Convert.ToInt32(Console.ReadLine());
            if (a > b) 
            {
                Console.WriteLine("max a");
            }
            else
            Console.WriteLine("max b");
        break;

    case 4:
       Console.Write("Введите первое число: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число отличное от первого: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число отличное от первого и второго: ");
        int e = Convert.ToInt32(Console.ReadLine());
            if (c > d && c > e) 
            { Console.WriteLine(c);
            }
            if (d > c && d > e)
            { Console.WriteLine(d);
            }
            else
            Console.WriteLine(e);
        break;
    
    case 6:
       Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
         { Console.WriteLine("Это число четно");
         }
         else
         { Console.WriteLine("Это число нечетное");
         }
        break;
        
    case 8:
        Console.Write("Введите число: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        while (i <= N)
        { Console.WriteLine(i);
        i = i + 2;
        }
        break;

    default:
        Console.WriteLine("Такого номера не существует");
        break;
}