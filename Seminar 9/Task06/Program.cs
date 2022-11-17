// Проверка на простое число: 

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

bool Validate(int number, int numberLess)
{
    if (numberLess <= 1) return true;
    return number % numberLess != 0 && Validate(number, numberLess - 1);
}

int myNumber = Prompt("Введите число: ");
if(Validate(myNumber, myNumber - 1)) Console.WriteLine("+");
else Console.WriteLine("-");