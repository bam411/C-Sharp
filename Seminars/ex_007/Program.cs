// Задача 7. 
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int lastDigit = number % 10;
Console.WriteLine(lastDigit);
