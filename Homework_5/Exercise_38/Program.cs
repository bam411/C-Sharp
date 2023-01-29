// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] numbers = new double[5];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(1, 100) / 10.0;
    Console.Write(numbers[i] + " ");
}

double max = numbers[0];
double min = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (max < numbers[i])
    {
        max = numbers[i];
    }
    if (min > numbers[i])
    {
        min = numbers[i];
    }
}

double result = max - min;

Console.WriteLine($"-> {result}");