int Prompt(string massage)
{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}



int number = Prompt("Введите число для перевод в двоичную систему: ");
Console.WriteLine($"{DoubleNumber(number)}");