// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 1)
    {
        Console.WriteLine("Ой! Вы ввели не натуральное число.");
        return false;
    }
    return true;
}

int ProdNumbers (int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i ++)
    {
        sum *= i;
    }
    return sum;
}

int num = Prompt("Введите натуральное число: ");

if(ValidateNumber(num)) Console.WriteLine($"Сумма чисел от 1 до {num}: {ProdNumbers(num)}.");