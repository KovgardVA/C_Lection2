// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

int Prompt(string massage)
{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateCoord(int xCoord, int yCoord)
{
    if (xCoord == 0 || yCoord == 0)
    {
        Console.WriteLine("Точка находится на одной из осей.");
        return false;
    }
    return true;
}

int GetQuarter(int x, int y)
{
    if (y > 0 && x > 0)
    {
        return 1;
    }
    if (y > 0 && x < 0)
    {
        return 2;
    }
    if (y < 0 && x < 0)
    {
        return 3;
    }
    return 4;
}

int x = Prompt("Введите значение X: ");
int y = Prompt("Введите значение Y: ");

if (!ValidateCoord(x, y))
{
    return;
}

Console.WriteLine($"Точка находится в {GetQuarter(x, y)} четверти.");