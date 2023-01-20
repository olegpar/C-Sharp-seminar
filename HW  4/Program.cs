Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 25:
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
       Console.Write("Введите число А: ");
       int A = Convert.ToInt32(Console.ReadLine());
       Console.Write("Введите число B: ");
       int B = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        int result = A;
       while(i <= B)
        {
            result = result * A;
            i ++;
        }   
        Console.Write("Ответ: " + result);
    break;

    case 27:
 // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12    
        int Sum(int N)
        {
        int B = 0;
        int sum = 0;
        while(N > 0)
            {
            B = N % 10;
            sum = sum + B;
            N = N / 10;  
            }
            return sum;
        }
        Console.Write("Введите число: ");
        int Num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Сумма чисел в числе: " + Sum(Num));
    break;

    case 29:
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

        int [] array = new int[8];
            for(int I = 0; I < array.Length; I++)
        {
            array[I] = new Random(). Next(0, 99);
            // Console.Write(array[i] + " ");
        }
        Console.WriteLine('[' + string.Join(", ", array) + ']');
    break;

        default:
            Console.WriteLine("Такого задания не существует");
        break;
    }


