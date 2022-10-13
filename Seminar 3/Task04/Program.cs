// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

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

// int num = Prompt("Введите натуральное число: ");
// double[] squart = new double[num];
// int squartNumber = 1;
// for (int i = 0; i < num; i ++)
// {
//     squart[i] = Math.Pow(squartNumber, 2);
//     squartNumber++;
// }
// Console.WriteLine(squart); // Вывод доработать.

int num = Prompt("Введите натуральное число: ");

if(ValidateNumber(num))
{
    Console.Write($"Квадраты от 1 до {num}: ");
    for (int i = 1; i <= num; i ++)
    {
        Console.Write(Math.Pow(i, 2) + " | ");
    }
}