int randomNumber = new Random().Next(10,100);
Console.WriteLine("Ваше число: " + randomNumber);

if (randomNumber / 10 > randomNumber % 10) {
    Console.WriteLine ("Наибальшее число: " + randomNumber / 10);
}
else 
{
    Console.WriteLine ("Наибольшая цифра: " + randomNumber % 10);
}