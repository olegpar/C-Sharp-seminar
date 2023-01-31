Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 64:
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
