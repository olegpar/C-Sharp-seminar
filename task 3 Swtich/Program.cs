Console.Write("Введите номер дня недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

switch (DayNumber)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Субота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;

    default:
        Console.WriteLine("Такого дня не существует");
        break;
}

