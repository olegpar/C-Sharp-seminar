int number = new Random().Next(10,100);
Console.WriteLine("Cлучайное число " + number);
int digit1 = number/10;
int digit2 = number%10;
if (digit1 > digit2)
{
    Console.WriteLine($"Первая цифра {digit1} больше второй {digit2}");
}
else
{
    Console.WriteLine($"Вторая {digit2} цифра больше первой {digit1}");
}
