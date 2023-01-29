// Задача 3. 
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите число: ");
string? input = Console.ReadLine();
int dayNumber = Convert.ToInt32(input);

if (dayNumber == 1)
{
    Console.WriteLine("Понедельник");
}
else if (dayNumber == 2)
{
    Console.WriteLine("Вторник");
}
else if (dayNumber == 3)
{
    Console.WriteLine("Среда");
}
else if (dayNumber == 4)
{
    Console.WriteLine("Четверг");
}
else if (dayNumber == 5)
{
    Console.WriteLine("Пятница");
}
else if (dayNumber == 6)
{
    Console.WriteLine("Суббота");
}
else if (dayNumber == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Такого дня недели не существует!");
}