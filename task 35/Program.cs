// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0

int [] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 1000);
        }
        return array;
}
int[] array = new int [5];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(" ", array));
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array [i] >= 10 && array [i] < 100)
    {
        count++;
    }
}
Console.WriteLine("В массиве количество чисел от 10 до 99: " + count);
