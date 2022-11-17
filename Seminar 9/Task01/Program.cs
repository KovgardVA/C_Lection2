// Задайте значение N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от 1 до N при помощи рекурсии.

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int number)
{
    if (number <= 0) return;
    PrintNumbers(number - 1);
    Console.Write(number + " ");
}

int myNumber = Prompt("Введите число: ");
PrintNumbers(myNumber);