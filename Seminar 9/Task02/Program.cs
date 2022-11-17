// Задайте значения M и N. Напишите программу, которая рекурсивно
// выведет все натуральные числа в промежутке от M до N.

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int from, int to)
{
    if (to < from) return;
    PrintNumbers(from, to - 1);
    Console.Write(to + " ");
}

int firstNumber = Prompt("Введите число от: ");
int secondNumber = Prompt("Введите число до: ");
PrintNumbers(firstNumber, secondNumber);