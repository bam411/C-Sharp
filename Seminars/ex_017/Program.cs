// Задача №17. 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int x = ReadInt("Введите точку x: ");
int y = ReadInt("Введите точку y: ");

if (x == 0 || y == 0)
{
    Console.WriteLine("x и y не могут быть равны 0");
    return;
}

if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
