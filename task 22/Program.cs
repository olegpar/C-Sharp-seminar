// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Write("Введите любое число: ");
double N = Convert.ToInt32(Console.ReadLine());
for(double i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 2) + " ");
}