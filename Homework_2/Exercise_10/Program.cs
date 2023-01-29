// Задача 10:
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1 

Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int divideNumber = number / 10;
int secondDigit = divideNumber % 10;

Console.WriteLine($"{number} -> {secondDigit}");


// working with any number like exercise 13

//Console.Write("Введите число:");
//int number = Convert.ToInt32(Console.ReadLine());
//string numText = Convert.ToString(number);

//Console.WriteLine($"{number} -> {numText[1]}");
