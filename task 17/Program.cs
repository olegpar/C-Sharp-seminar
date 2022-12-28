Console.Write("Введите номер четверти: ");
int Q = Convert.ToInt32(Console.ReadLine());

if(Q == 1)
{
    Console.WriteLine("X > 0; Y > 0");
}
else if(Q == 2)
{
    Console.WriteLine("X < 0; Y > 0");
}
else if(Q == 3)
{
    Console.WriteLine("X < 0; Y < 0");
}
else if(Q == 4)
{
    Console.WriteLine("X > 0; Y < 0");
}
else
{
    Console.WriteLine("нет такой четверти");  
}

string[] Qs =  {"X > 0; Y > 0",
                "X < 0; Y > 0",
                "X < 0; Y < 0",
                "X > 0; Y < 0"};
Console.Write("Введите номер четверти: ");
int q = Convert.ToInt32(Console.ReadLine());
if(q >= 1 && q <= 4)
{
    Console.WriteLine(Qs[q-1]); 
}
else
{
    Console.WriteLine("нет такой четверти"); 
}
