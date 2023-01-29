// Задача 8:
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число:");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = 1;
Console.Write(numA + " -> ");

while (numB < numA)
{
    Console.Write((numB + 1) + ", ");
    numB = numB + 2;
}
