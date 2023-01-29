// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

Sum(m, n, temp = 0);

void Sum(int m, int n, int temp)
{
    temp += n;
    if (n <= m)
    {
        Console.WriteLine($"Сумма = {temp}");
        return;
    }
    Sum(m, n - 1, temp);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}