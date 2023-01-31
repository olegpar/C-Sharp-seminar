// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetweenMN(int a, int b)
{
    int sum = 0;
    for(int i = a; i <= b; i++)
    // if (a == b) return 0;
    // if (a > b)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumBetweenMN(M,N));