// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int aX = ReadInt("Введите координату X точки A: ");
int aY = ReadInt("Введите координату Y точки A: ");
int bX = ReadInt("Введите координату X точки B: ");
int bY = ReadInt("Введите координату Y точки B: ");

int sqrSideX = (aX - bX) * (aX - bX);
int sqrSideY = (aY - bY) * (aY - bY);
double distance = Math.Sqrt(sqrSideX + sqrSideY);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
