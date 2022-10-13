int Prompt(string massage)
{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstNumber = Prompt("Введите первое число: ");
int secondNumber = Prompt("Введите первое число: ");

if (firstNumber % secondNumber == 0)
{
    Console.WriteLine($"Число {firstNumber} кратно числу {secondNumber}");
}
else
{
    Console.WriteLine("Числа не кратные! Остаток от деления: " + firstNumber % secondNumber);
}