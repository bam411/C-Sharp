// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100, 1000);
    Console.Write(numbers[i] + " ");
}

int result = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}

Console.WriteLine($"\n{result}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}