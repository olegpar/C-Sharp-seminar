// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.7; 7.2; 2.1; 7.8] -> 5.7

double [] FillArrayWithRandom(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            array[i] =  Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2);
        }
        return array;
}
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double [] array = new double [length];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(" ", array));
double max = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(array [i] > max)
    {
        max = array [i];
    }
}
double min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(array [i] < min)
    {
        min = array [i];
    }
}
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: " + min);
Console.WriteLine("Разница между максимальным и минимальным числом = " + (max - min));
