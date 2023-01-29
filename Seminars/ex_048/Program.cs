// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int number = ReadInt("Введите N: ");
Console.WriteLine(NaturalNumber(number));

int NaturalNumber(int n)
{
    if (n == 1)
        return 1;
    else
    {
        Console.Write(NaturalNumber(n - 1) + ", ");
    }
    return n;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}