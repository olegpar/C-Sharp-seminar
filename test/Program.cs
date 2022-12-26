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

