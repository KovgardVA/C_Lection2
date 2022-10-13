Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int lastNumber = number % 10;
    Console.WriteLine($"Последняя цифра: {lastNumber}");
}
else{
    Console.WriteLine("Это не трехзначное число!");
}