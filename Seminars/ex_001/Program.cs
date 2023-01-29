// Задача 1
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB == numberA * numberA)
{
    Console.WriteLine(numberA + " является квадратом " + numberB);
}
else
{
    Console.WriteLine(numberA + " не является квадратом " + numberB);
}
