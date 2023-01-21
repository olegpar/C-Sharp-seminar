// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 10);
        }
        return array;
}
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(" ", array));

int newLength = array.Length/2 + array.Length%2;
int[] newArray = new int [newLength];
for(int i = 0; i < array.Length/2; i++)
{
    newArray [i] = array [i] * array[array.Length - 1 - i];
}
if(array.Length % 2 > 0)
{
    newArray[newArray.Length -1] = array[array.Length/2];
}
Console.Write("Ваш получившийся массив: ");
Console.WriteLine(string.Join(", ", newArray));


