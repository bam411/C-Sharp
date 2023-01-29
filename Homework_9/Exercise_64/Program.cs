// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int n = ReadInt("Введите N: ");
int m = 1;
NaturalNumber(n, m);

void NaturalNumber(int n, int m)
{
    if (n > m)
    {
        Console.Write($"{n}, ");
        NaturalNumber(n - 1, m);
    }
    if (n == m)
    {
        Console.WriteLine($"{n} ");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}