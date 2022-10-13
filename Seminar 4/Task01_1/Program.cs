// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int CountOfDigit (int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

int num = Prompt("Введите число: ");
Console.WriteLine($"В числе {num} - {CountOfDigit(num)} цифры.");