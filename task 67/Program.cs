// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Sum(int number)
{
    if(number == 0)
    {
        return 0;
    }
    int temp = 0;
    int sum = 0;
    temp = number%10;
    Console.WriteLine(sum+" "+temp); // показывает пошагово что происходит
    sum = temp + Sum(number/10);
     return sum;
    // return number%10 + Sum(number/10);
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = Sum(N);
Console.WriteLine(sum);