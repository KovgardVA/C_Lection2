// Определите, является ли число степенью двойки:

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

bool Validate(int number)
{
    if (number <= 2) return true;
    return number % 2 == 0 && Validate(number / 2);
}

int myNumber = Prompt("Введите число: ");
if(Validate(myNumber)) Console.WriteLine("+");
else Console.WriteLine("-");