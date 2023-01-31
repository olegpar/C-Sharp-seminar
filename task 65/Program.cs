void MNArray( int numbers1, int numbers2)
{
    if( numbers1 == numbers2 -1)
    {
    return; 
    }
MNArray(numbers1 -1, numbers2);
Console.Write(numbers1 + " ");
}
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
MNArray(m,n);