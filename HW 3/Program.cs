Console.Write("Введите номер задания: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

switch (DayNumber)
{
    case 19:
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
       Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string S = number.ToString();
        if(S[0] == S[4] && S[1] == S[3])
        {
            Console.WriteLine("Это число является палиндромом");
        }
        else
        {
            Console.WriteLine("Это число НЕ является палиндромом");
        }
        break;

    case 21: 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
        Console.Write("Введите координаты X1 первой точки: ");
        double X1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координаты Y1 первой точки: ");
        double Y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координаты Z1 первой точки: ");
        double Z1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координаты X1 второй точки: ");
        double X2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координаты Y1 второй точки: ");
        double Y2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координаты Z1 первой точки: ");
        double Z2 = Convert.ToInt32(Console.ReadLine());

        double result = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
        Console.WriteLine("Расстояние между точками координат: " + Math.Round(result, 2)); 
        break;
    
    case 23:
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
        Console.Write("Введите любое число: ");
        double N = Convert.ToInt32(Console.ReadLine());
        for(double i = 1; i <= N; i++)
        {
            Console.Write(Math.Pow(i, 3) + " ");
        }
        break;
    default:
        Console.WriteLine("Такого задания не существует");
        break;
}

