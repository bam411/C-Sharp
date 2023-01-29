// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write($"Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

void InputNumbers(int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int searchPositive(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(size);

Console.WriteLine(searchPositive(numbers));