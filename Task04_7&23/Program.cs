﻿Console.WriteLine("Давай проверим, кратно ли число одновременно 7 и 23!");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Число {number} кратно одновременно 7 и 23!");
}
else
{
    Console.WriteLine("Никакой кратности! :(");
}
