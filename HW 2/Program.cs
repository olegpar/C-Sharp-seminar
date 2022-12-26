Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 10: // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        int number1 = new Random().Next(10,1000);
        Console.WriteLine("Cлучайное число " + number1);
        int digit1 = number1/10;
        int digit2 = digit1 % 10;
        Console.WriteLine(digit2);

        int number2 = new Random().Next(10,1000);
        Console.WriteLine("Cлучайное число " + number2);
        string S = number2.ToString();
        Console.WriteLine(S[1]);
    break;

    case 13: // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    Console.Write("Выберите вариант решения: string - 1, while - 2: ");
    int variant = Convert.ToInt32(Console.ReadLine());
    switch (variant)
    {
        case 1:
        Console.Write("Введите любое число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string Str = num.ToString();
        if (num < 0)
            {
            num = -num;
            Console.WriteLine(Str[3]);
            }
        else if (num < 100)
        {
            Console.WriteLine("Третьей цифры нет");   
        }
        else
        Console.WriteLine(Str[2]);
        break;
        
        case 2:
        Console.Write("Введите любое число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        if (num2 < 0)
        {
            num2 = -num2;
        }
            if (num2 > 999)
            {
                while(num2 > 999)
                {
                    num2 = num2/10;
                    i = i + 1;
                }
            Console.WriteLine("Третья цифра " + num2 % 10);
            }  
            else if (num2 < 100)
                {
                Console.WriteLine("Третьей цифры нет");   
                }
            else
            {
            Console.WriteLine("Третья цифра " + num2 % 10); 
            } 
        break;         
    }
    break;

    case 15: //  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    Console.Write("Введите номер дня недели: ");
    int DayNumber = Convert.ToInt32(Console.ReadLine());
        if(DayNumber == 1 || DayNumber == 2 || DayNumber == 3 || DayNumber == 4 || DayNumber == 5)
        {
            Console.WriteLine("Это будний день");
        }
        else if (DayNumber == 6 || DayNumber == 7)
        {
            Console.WriteLine("Ура! Это выходной!");
        }
        else
        {
            Console.WriteLine("Такого дня недели не существует");
        }
    break;

    default:
        Console.WriteLine("Такого номера не существует");
    break;
}