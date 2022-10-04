int randomNumber = new Random().Next(10,100);
Console.WriteLine("Ваше число: " + randomNumber);

int firstNumber = randomNumber / 10;
int secondNumber = randomNumber % 10;

if (firstNumber > secondNumber) {
    Console.WriteLine ("Наибальшее число: " + firstNumber);
}
else 
{
    Console.WriteLine ("Наибальшее число: " + secondNumber);
}