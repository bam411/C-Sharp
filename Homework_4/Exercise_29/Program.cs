// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]

Console.Write("Введите количество элементов: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}

PrintArray();

void PrintArray()
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
}