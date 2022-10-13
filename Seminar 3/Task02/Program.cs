// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateQuarter(int quarterNumber)
{
    if (quarterNumber < 1 || quarterNumber > 4)
    {
        Console.WriteLine("Вы ввели неправильное число!");
        return false;
    }
    return true;
}

// string GetCoords(int quarterNumber)
// {
//     if (quarterNumber == 1)
//     {
//         return "X (0; +∞), Y (0; +∞)";
//     }
//     if (quarterNumber == 2)
//     {
//         return "X (-∞; 0), Y (0; +∞)";
//     }
//     if (quarterNumber == 3)
//     {
//         return "X (-∞; 0), Y (-∞; 0)";
//     }
//     return "X (0; +∞), Y (-∞; 0)";
// }

string GetCoords(int quarterNumber)
{
    switch(quarterNumber)
    {
        case 1:
        return "X (0; +∞), Y (0; +∞)";
        case 2:
        return "X (-∞; 0), Y (0; +∞)";
        case 3:
        return "X (-∞; 0), Y (-∞; 0)";
        default:
        return "X (0; +∞), Y (-∞; 0)";
    }
}


int quarter = Prompt("Введите номер четверти: ");

if(ValidateQuarter(quarter))
{
    Console.WriteLine(GetCoords(quarter));
}