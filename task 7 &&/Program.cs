Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100 && a < 1000)
{
   Console.Write("Последняя цифра: ");
   Console.Write(a % 10);
}
else
{
    Console.Write("Вы ввели не трехзначное число");
}