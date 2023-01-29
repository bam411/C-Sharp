// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int temp = 0;
int result = 0;

for (int i = 1; number > 0; i++)
{
    temp = number - number % 10;
    result += number - temp;
    number /= 10;
}

Console.WriteLine(result);
