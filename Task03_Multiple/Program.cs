Console.WriteLine("Давайте проверим кратность чисел!");
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
    Console.WriteLine($"Число {firstNumber} кратно числу {secondNumber}");
}
else
{
    Console.WriteLine("Числа не кратные! Остаток от деления: " + firstNumber % secondNumber);
}