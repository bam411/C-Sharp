﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int number = ReadInt("Введите число: ");
int i = 1;
while (i <= number)
{
    Console.Write(i * i + " ");
    i++;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
