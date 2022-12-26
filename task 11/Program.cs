// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(10,1000);
Console.WriteLine("Cлучайное число " + number);
int digit1 = number/100;
int digit3 = number%10;
Console.WriteLine(digit1*10 + digit3);
