﻿// Задача 15:
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Выходной");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    Console.WriteLine("Не выходной");
}