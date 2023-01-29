// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int numbers, int min, int max)
{
    int[] randomNums = new int[numbers];
    int sum = 0;

    for (int i = 0; i < randomNums.Length; i++)
    {
        randomNums[i] = new Random().Next(min, max);

        Console.Write(randomNums[i] + " ");

        if (i % 2 != 0)
        {
            sum += randomNums[i];
        }
    }
    return sum;
}

int randomNums = RandomNumbers(numbers, -10, 10);

Console.WriteLine($"\n{randomNums}");