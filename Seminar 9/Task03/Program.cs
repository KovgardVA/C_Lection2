// Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр. Использовать рекурсию.

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int PrintSumOfDigits(int number)
{
    if (number <= 0) return 0;
    return number % 10 + PrintSumOfDigits(number / 10);
}

int myNumber = Prompt("Введите число: ");
Console.WriteLine($"{PrintSumOfDigits(myNumber)}");