// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.Write("Введите через запятую координаты X первой точки: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите через запятую координаты Y первой точки: ");
double Y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите через запятую координаты X второй точки: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите через запятую координаты Y второй точки: ");
double Y2 = Convert.ToInt32(Console.ReadLine());


double result = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
Console.WriteLine(Math.Round(result, 2)); 