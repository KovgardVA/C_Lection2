// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// double[] Prompt(string messageX, string messageY)
// {
//     double[] Coords = new double [2];
//     Console.Write(messageX);
//     Coords[0] = Convert.ToDouble(Console.ReadLine());
//     Console.Write(messageY);
//     Coords[1] = Convert.ToDouble(Console.ReadLine());
//     return Coords;
// }

// Console.WriteLine("Введите координаты первой точки:");
// double[] firstCoords = Prompt("Координата X: ", "Координата Y: ");
// Console.WriteLine("Введите координаты второй точки:");
// double[] secondCoords = Prompt("Координата X: ", "Координата Y: ");

// double distance = Math.Sqrt(Math.Pow(secondCoords[0]-firstCoords[0], 2) + Math.Pow(secondCoords[1] - firstCoords[1], 2));

// Console.WriteLine($"Расстояние между точками: {distance}");

const int X = 0;
const int Y = 1;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoint(int point)
{
    int[] Coords = new int[2];
    Coords[X] = Prompt($"Координата X{point}: ");
    Coords[Y] = Prompt($"Координата Y{point}: ");
    return Coords;
}

int Power2(int arg)
{
    return arg * arg;
}

int[] firstPoint = InputPoint(1);
int[] secondPoint = InputPoint(2);

double distance = Math.Sqrt(Power2(secondPoint[X] - firstPoint[X]) + Power2(secondPoint[Y] - firstPoint[Y]));

Console.WriteLine($"Расстояние между точками: {distance:f2}");