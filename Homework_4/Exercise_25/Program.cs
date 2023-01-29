// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numberA = ReadInt("Введите первое число: ");
int numberB = ReadInt("Введите второе число: ");

int result = 1;

for (int i = 1; i <= numberB; i++)
{
    result *= numberA;
}

Console.WriteLine(result);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}