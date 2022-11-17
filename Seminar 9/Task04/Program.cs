// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int Power(int number, int exp)
{
    if (exp <= 0) return 1;
    return number * Power(number, exp - 1);
}

int firstNumber = Prompt("Введите число: ");
int secondNumber = Prompt("Введите степень: ");
Console.WriteLine($"{Power(firstNumber, secondNumber)}");