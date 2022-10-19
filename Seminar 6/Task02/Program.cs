int Prompt(string massage)
{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// bool ValidateTriangle(int aSide, int bSide, int cSide)
// {
//     if (aSide > 0 && bSide > 0 && cSide > 0)
//     {
//         if(
//             aSide + bSide < cSide &&
//             bSide + cSide < aSide &&
//             aSide + cSide < bSide
//         )
//         {
//             Console.WriteLine("Такой треугольник может существовать!");
//             return true;
//         }
//         else 
//         {
//             Console.WriteLine("Такого треугольника не может существовать!");
//             return false;
//         }
//     }
//     Console.WriteLine("Длины сторон должны быть больше нуля!")
//     return false;
// }

bool CheckTriangle(int aSide, int bSide, int cSide)
{
    if (aSide + bSide < cSide) return false;
    if (bSide + cSide < aSide) return false;
    if (aSide + cSide < bSide) return false;
    return true;
}

int a = Prompt("Введите сторону А: ");
int b = Prompt("Введите сторону B: ");
int c = Prompt("Введите сторону C: ");