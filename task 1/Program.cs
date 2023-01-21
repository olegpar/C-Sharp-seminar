Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Чему равен квадрат этого числа? ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a * a;

if(b == c)
    { Console.WriteLine ("Верно!");
    }
else 
    { Console.WriteLine ("Подумайте еще раз");
}

