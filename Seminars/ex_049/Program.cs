// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int start = ReadInt("Введите M: ");
int end = ReadInt("Введите N: ");
NaturalNumber(start, end);

void NaturalNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m + 1, n);
    }
    if (m > n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m - 1, n);
    }
    if (m == n)
    {
        Console.Write($"{m} ");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}